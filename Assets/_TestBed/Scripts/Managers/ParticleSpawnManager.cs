using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawnManager : MonoBehaviour
{
    public static ParticleSpawnManager instance;

    public ParticleSystem[] particlePrefabs;
    public int maxParticles = 20;

    private static ParticleSystem[][] systems;
    private static int[] indices;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        int count = particlePrefabs.Length;
        systems = new ParticleSystem[count][];
        indices = new int[count];
        for(int i = 0; i < count; i++)
        {
            systems[i] = new ParticleSystem[maxParticles];
            for(int j = 0; j < maxParticles; j++)
            {
                systems[i][j] = Instantiate(particlePrefabs[i]);
            }
        }
    }

    public static void Play(string systemName, Vector3 position)
    {
        for(int i = 0; i < instance.particlePrefabs.Length; i++)
        {
            if (instance.particlePrefabs[i].name == systemName)
            {
                ParticleSystem[] pool = systems[i];
                int index = indices[i];
                ParticleSystem system = pool[index];
                system.transform.position = position;
                system.Play();
                indices[i] = (index + 1) % instance.maxParticles;
                break;
            }
        }
    }
}
