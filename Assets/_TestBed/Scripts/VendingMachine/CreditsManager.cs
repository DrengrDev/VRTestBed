using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditsManager : MonoBehaviour
{
    public float availableCreds;
    public TextMeshProUGUI credsText;

    private void Start()
    {
        credsText.text = "Available Balance: $" + availableCreds.ToString();
    }

    private void Update()
    {
        credsText.text = "Available Balance: $" + availableCreds.ToString();
    }

    public void UpdateCredits(float value)
    {
        availableCreds += value;
    }
}
