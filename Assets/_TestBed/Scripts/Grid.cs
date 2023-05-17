using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject targets;
    public GameObject[] targetPos;

    int timer = 2;

    private void Update()
    {
        StartCoroutine(TargetSpawn());
    }

    IEnumerator TargetSpawn()
    {
        yield return new WaitForSeconds(timer);
        for (int i = 0; i < targetPos.Length; i++)
        {
            Vector3 spawnPos = targetPos[i].transform.position;
            Instantiate(targets, spawnPos, Quaternion.identity);
        }
    }
}
