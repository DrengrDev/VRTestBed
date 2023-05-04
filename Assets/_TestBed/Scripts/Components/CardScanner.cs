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

    private float charge = 50.50f;
    private bool canDecrease = true;

    private void Start()
    {
        //card = GetComponent<CreditCard>();
    }

    private void OnTriggerEnter(Collider c)
    {
        bool isTag = c.gameObject.CompareTag("CardTrigger");
        if (c.gameObject.GetComponentInParent<CreditCard>() && isTag)
        {
            if (canDecrease) StartCoroutine(DelayedBalance(5f));
        }
    }

    IEnumerator DelayedBalance(float delay)
    {
        canDecrease = false;
        _whenScanned.Invoke();
        yield return new WaitForSeconds(delay);
        canDecrease = true;
    }
}
