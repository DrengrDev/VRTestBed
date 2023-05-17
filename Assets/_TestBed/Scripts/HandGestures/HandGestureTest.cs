using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGestureTest : MonoBehaviour
{
    public Image imageLeft, imageRight;

    public void ChangeColorLeft()
    {
        imageLeft.color = Color.green;
    }

    public void ChangeColorRight()
    {
        imageRight.color = Color.green;
    }
}
