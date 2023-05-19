using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkSpawner : MonoBehaviour
{
    public void SpawnParticle(GameObject g)
    {
        ParticleSpawnManager.Play("Sparks 1", g.transform.position);
    }
}
