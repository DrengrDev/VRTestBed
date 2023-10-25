using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeColor : MonoBehaviour
{
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void Fade(GameObject obj)
    {
        StartCoroutine(FadeOut(obj));
    }

    IEnumerator FadeOut(GameObject obj)
    {
        //Get the initial alpha value of the image
        float startAlpha = _image.color.a;

        for (float t = 0; t <= 1f; t += Time.deltaTime)
        {
            //Calculate the new alpha value using Lerp
            float newAlpha = Mathf.Lerp(startAlpha, 0f, t);

            //Create a new color with the updated alpha
            Color newColor = new Color(_image.color.r, _image.color.g, _image.color.b, newAlpha);

            //Apply the new color to the image
            _image.color = newColor;

            yield return null;
        }

        //Ensure the final alpha is fully transparent
        Color finalColor = new Color(_image.color.r, _image.color.g, _image.color.b, 0f);
        _image.color = finalColor;

        obj.SetActive(false);
    }
}
