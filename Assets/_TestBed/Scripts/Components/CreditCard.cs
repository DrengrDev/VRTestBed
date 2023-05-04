using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditCard : MonoBehaviour
{
    public float cardBalance;
    public TextMeshProUGUI balanceText;

    private void Start()
    {
        balanceText.text = "$" + cardBalance.ToString();
    }

    private void Update()
    {
        balanceText.text = "$" + cardBalance.ToString();
    }

    public void IncreaseBalance(float balanceDiff)
    {
        cardBalance += balanceDiff;
    }

    public void DecreaseBalance(float balanceDiff)
    {
        cardBalance -= balanceDiff;
    }
}
