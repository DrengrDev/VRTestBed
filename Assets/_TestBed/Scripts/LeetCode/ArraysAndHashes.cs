using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndHashes : MonoBehaviour
{
    public GameObject[] objects;

    private void Start()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].transform.position = new Vector3(0, 0 + i, 0);
        }
    }
}
