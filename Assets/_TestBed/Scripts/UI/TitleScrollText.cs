using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScrollText : MonoBehaviour
{
    private RectTransform title;
    private float canvasLength;

    private void Start()
    {
        title = GetComponent<RectTransform>();
        canvasLength = title.anchoredPosition.x;
    }

    private void Update()
    {
        if (transform.position.x < -canvasLength)
        {
            RepositionTitle();
        }
    }

    void RepositionTitle()
    {
        Vector2 offset = new Vector2(canvasLength * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
