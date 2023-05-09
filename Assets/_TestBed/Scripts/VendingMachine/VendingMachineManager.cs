using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VendingMachineManager : MonoBehaviour
{
    public float availableCreds;
    public TextMeshProUGUI credsText;

    public GameObject[] images;

    private GameObject selectedImage;
    private void Start()
    {
        credsText.text = "Available Balance: $" + availableCreds.ToString();

        for(int i = 0; i < images.Length; i++)
        {
            images[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        credsText.text = "Available Balance: $" + availableCreds.ToString();
    }

    public void IncreaseCredits(float value)
    {
        availableCreds += value;
    }

    public void DecreaseCredits(float value)
    {
        availableCreds -= value;
    }

    public void ChangeImage(int index)
    {
        if(selectedImage != null)
        {
            selectedImage.SetActive(false);
        }

        selectedImage = images[index];
        selectedImage.SetActive(true);
    }
}
