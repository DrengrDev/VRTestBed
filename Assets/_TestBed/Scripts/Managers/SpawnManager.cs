using Paraphernalia.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager spawnManager;

    [SerializeField] GameObject[] prefabs;

    private Dictionary<string, List<GameObject>> poolDictionary = new Dictionary<string, List<GameObject>>();
    private Dictionary<string, GameObject> prefabDictionary = new Dictionary<string, GameObject>();

    private void Awake()
    {
        if(spawnManager == null)
        {
            spawnManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogWarning("Spawner already exists. Disabling");
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        for(int i = 0; i < prefabs.Length; i++)
        {
            string name = prefabs[i].name;
            poolDictionary[name] = new List<GameObject>();
            prefabDictionary[name] = prefabs[i];
        }
    }

    public static GameObject Spawn(string name)
    {
        if (!spawnManager.poolDictionary.ContainsKey(name))
        {
            Debug.LogWarning("Pool named '" + name + "' does not exist.");
            return null;
        }

        GameObject g = spawnManager.poolDictionary[name].Find(IsInactive);
        if(g == null)
        {
            g = Instantiate(spawnManager.prefabDictionary[name]);
            g.transform.SetParent(spawnManager.transform);
            spawnManager.poolDictionary[name].Add(g);
        }

        return g;
    }

    private static bool IsInactive(GameObject g)
    {
        return !g.activeSelf;
    }
}
