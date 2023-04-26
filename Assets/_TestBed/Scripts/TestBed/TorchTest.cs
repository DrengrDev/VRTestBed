using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.GetComponentInChildren<FingerTrigger>())
        {
            Debug.LogWarning("Touched Torch");
        }
    }
}
