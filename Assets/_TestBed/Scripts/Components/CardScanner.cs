using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardScanner : MonoBehaviour
{
    public CreditCard card;

    [SerializeField]
    private UnityEvent _whenScanned = new UnityEvent();
    public UnityEvent WhenScanned => _whenScanned;

    private bool canDecrease = true;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        bool isTag = c.gameObject.CompareTag("CardTrigger");
        if (c.gameObject.GetComponentInParent<CreditCard>() && isTag)
        {
            if (canDecrease)
            {
                StartCoroutine(DelayedBalance(5f)); 
            }
        }
    }

    IEnumerator DelayedBalance(float delay)
    {
        canDecrease = false;
        card.Fill();
        yield return new WaitForSeconds(delay);
        _whenScanned.Invoke();
        canDecrease = true;
    }
}
