using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleThroughObjects : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject objectPlacement;

    private Vector3 placement;
    private int currentIndex;
    private void Start()
    {
        placement = objectPlacement.transform.position;
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
        g.transform.position = placement;
    }
}
