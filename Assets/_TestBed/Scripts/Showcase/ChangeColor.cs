using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject[] objects;

    public Color[] colors;

    public void ColorChange()
    {
        int[] random = new int[colors.Length];

        for(int i = 0; i < objects.Length; i++)
        {
            int randNum = Random.Range(0, random.Length);
            objects[i].GetComponent<Renderer>().material.color = colors[randNum];
        }
    }
}
