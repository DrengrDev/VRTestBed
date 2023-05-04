using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreditCard : MonoBehaviour
{
    public float cardBalance;
    public TextMeshProUGUI balanceText;

    private Image sprite;

    private void Start()
    {
        sprite = GetComponentInChildren<Image>();
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

    public void Fill()
    {
        StartCoroutine(FillImage(5f));
    }

    public IEnumerator FillImage(float fillTime)
    {
        float time = 0;
        while(time < fillTime)
        {
            time += Time.deltaTime;
            sprite.fillAmount = time / fillTime;
            yield return null;
        }
    }
}
