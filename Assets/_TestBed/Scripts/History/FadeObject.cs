using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeObject : MonoBehaviour
{
    private Renderer[] renderers;
    private Color[] originalColors;

    private void Start()
    {
        //Get all Renderer components in the GameObject and its children
        renderers = GetComponentsInChildren<Renderer>(true);

        //Store the original colors
        originalColors = new Color[renderers.Length];
        for(int i = 0; i < renderers.Length; i++)
        {
            originalColors[i] = renderers[i].material.color;
        }
    }

    public void Fade(GameObject obj)
    {
        StartCoroutine(FadeOut(obj));
    }

    IEnumerator FadeOut(GameObject obj)
    {
        for(float t = 0; t < 1f; t += Time.deltaTime)
        {
            //Calculate the new alpha value for all materials
            float newAlpha = Mathf.Lerp(1f, 0f, t);

            //Update the alpha value for all materials
            for(int i = 0; i < renderers.Length; i++)
            {
                Color newColor = new Color(
                    originalColors[i].r,
                    originalColors[i].g,
                    originalColors[i].b,
                    newAlpha
                    );

                renderers[i].material.color = newColor;
            }

            yield return new WaitForEndOfFrame();
        }

        //Ensure the final alpha is fully transparent
        for(int i = 0; i < renderers.Length; i++)
        {
            Color finalColor = new Color(
                originalColors[i].r,
                originalColors[i].g,
                originalColors[i].b,
                0f
                );

            renderers[i].material.color = finalColor;
        }

        obj.SetActive(false);
    }
}
