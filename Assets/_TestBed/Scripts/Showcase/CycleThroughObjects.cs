using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleThroughObjects : MonoBehaviour
{
    public GameObject[] prefabs;

    int currentIndex;
    private void Start()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            currentIndex = i;
            prefabs[i].gameObject.SetActive(false);
        }
        currentIndex = 0;
        TurnOn(prefabs[currentIndex]);
    }

    public void ChangeObject()
    {
        if (currentIndex < prefabs.Length - 1)
        {
            TurnOff(prefabs[currentIndex]);
            currentIndex++;
            TurnOn(prefabs[currentIndex]);
        }
        else
        {
            TurnOff(prefabs[currentIndex]);
            currentIndex = 0;
            TurnOn(prefabs[currentIndex]);
        }
    }

    void TurnOff(GameObject g)
    {
        g.SetActive(false);
    }

    void TurnOn(GameObject g)
    {
        g.SetActive(true);
    }
}
