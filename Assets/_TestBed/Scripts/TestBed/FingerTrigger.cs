using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerTrigger : MonoBehaviour
{
    public GameObject finger;

    public int timer = 4;

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.GetComponentInParent<TorchTest>())
        {
            StartCoroutine(FlameDisapear());
        }
    }

    IEnumerator FlameDisapear()
    {
        finger.SetActive(true);
        yield return new WaitForSeconds(timer);
        finger.SetActive(false);
    }
}
