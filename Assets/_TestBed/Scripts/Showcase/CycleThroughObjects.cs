using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleThroughObjects : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject objectPlacement;

    public float rotationSpeed = 10f;

    private Vector3 placement;
    private GameObject currentObject;
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

    private void Update()
    {
        RotateObject(currentObject);
    }

    public void ChangeObjectForward()
    {
        if (currentIndex < prefabs.Length - 1)
        {
            TurnOff(currentObject);
            currentIndex++;
            TurnOn(prefabs[currentIndex]);
        }
        else
        {
            TurnOff(currentObject);
            currentIndex = 0;
            TurnOn(prefabs[currentIndex]);
        }
    }

    public void ChangeObjectBackward()
    {
        if(currentIndex > 0)
        {
            TurnOff(currentObject);
            currentIndex--;
            TurnOn(prefabs[currentIndex]);
        }
        else
        {
            TurnOff(currentObject);
            currentIndex = prefabs.Length -1;
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
        currentObject = g;
    }

    void RotateObject(GameObject g)
    {
        float rotSpeed = rotationSpeed * Time.deltaTime;
        Vector3 rotation = new Vector3(rotSpeed, 0f, 0f);
        g.transform.Rotate(rotation);
    }
}
