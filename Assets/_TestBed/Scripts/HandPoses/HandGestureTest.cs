using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGestureTest : MonoBehaviour
{
    //public Image imageLeft, imageRight;

    Color color;
    private void Start()
    {
        color = Color.red;
    }

    public void ChangeColor(Image image)
    {
        image.color = Color.green;
    }

    public void TurnColorBack(Image image)
    {
        image.color = color;
    }

    public void TurnOnText(GameObject g)
    {
        g.SetActive(true);
    }

    public void TurnOffText(GameObject g)
    {
        g.SetActive(false);
    }
}
