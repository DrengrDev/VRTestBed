using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingTestSpawn : MonoBehaviour
{
    public GameObject spawnArea;
    public GameObject prefab;

    private Vector3 spawnPosition;

    public void SpawnObject()
    {
        spawnPosition = spawnArea.transform.position;
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
