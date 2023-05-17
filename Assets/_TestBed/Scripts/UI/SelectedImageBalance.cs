using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectedImageBalance : MonoBehaviour
{
    public float balance;
    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = "$" + balance.ToString();
    }
}
