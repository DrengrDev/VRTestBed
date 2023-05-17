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

    public void ChangeColorLeft(Image image)
    {
        image.color = Color.green;
    }

    public void ChangeColorRight(Image image)
    {
        image.color = Color.green;
    }

    public void TurnColorBack(Image image)
    {
        image.color = color;
    }
}
