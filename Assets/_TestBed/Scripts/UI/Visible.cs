using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour
{
    private void OnBecameVisible()
    {
        GetComponent<RectTransform>().gameObject.SetActive(true);
    }

    private void OnBecameInvisible()
    {
        GetComponent <RectTransform>().gameObject.SetActive(false);
    }
}
