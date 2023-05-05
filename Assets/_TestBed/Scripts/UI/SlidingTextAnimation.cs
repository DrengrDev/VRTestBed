using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlidingTextAnimation : MonoBehaviour
{
    public GameObject text;
    public float speed = 50f;
    public float startX = -500f;
    public float startX1 = -500f;
    public float startX2 = -500f;
    public float endX = 500f;

    public RectTransform rectTransform1;
    public RectTransform rectTransform2;
    public RectTransform rectTransform3;

    Vector2 currentPos1;
    Vector2 currentPos2;

    //private float startTime;

    private void Start()
    {
       //rectTransform = GetComponent<RectTransform>();
        rectTransform1.anchoredPosition = new Vector2(startX, rectTransform1.anchoredPosition.y);
    }

    private void Update()
    {
        RepositionText();
        RepositionText1();
        RepositionText2();

    }

    void RepositionText()
    {
        rectTransform1.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);
        if (rectTransform1.position.x > endX)
        {
            rectTransform1.anchoredPosition = new Vector2(startX, rectTransform1.anchoredPosition.y);
        }
    }

    void RepositionText1()
    {
        rectTransform2.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);
        if (rectTransform2.position.x > endX)
        {
            rectTransform2.anchoredPosition = new Vector2(startX, rectTransform2.anchoredPosition.y);
        }
    }

    void RepositionText2()
    {
        rectTransform3.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);
        if (rectTransform3.position.x > endX)
        {
            rectTransform3.anchoredPosition = new Vector2(startX, rectTransform3.anchoredPosition.y);
        }
    }

    /*void SeconScrollTest()
    {
        rectTransform.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);

        if (rectTransform.anchoredPosition.x > endX)
        {
            rectTransform.anchoredPosition = new Vector2(startX, rectTransform.anchoredPosition.y);
        }
    }*/

    /*void FirstScrollTest()
    {
        float t = (Time.time - startTime) / duration;

        RectTransform rt = text.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(Mathf.Lerp(startX, endX, t), rt.anchoredPosition.y);
    }*/

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
    }
}
