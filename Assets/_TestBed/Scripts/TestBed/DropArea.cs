using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DropArea : MonoBehaviour
{
    public UnityEvent OnEntered;

    private Collider childCollider;

    private void Start()
    {
        childCollider = GetComponentInChildren<Collider>();
        if(childCollider != null && childCollider.isTrigger)
        {
            childCollider.enabled = true;
        }
        else
        {
            Debug.LogWarning("Collider cannot be found");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Syringe>())
        {
            OnEntered.Invoke();
        }
    }
}
