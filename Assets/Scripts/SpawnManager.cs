using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    private int prefabsToSpawn = 9;
    private void Start()
    {
        SpawnRandomPrefab();
    }
    private void SpawnRandomPrefab()
    {
        for (int i = 0; i < PrefabsToSpawn; i++)
        {
            int index = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[index], GenerateRandomPos(), prefabs[index].transform.rotation);
        }
    }

    private Vector3 GenerateRandomPos()
    {
        float randomX = Random.Range(-18, 18);
        float randomZ = Random.Range(-18, 18);

        return new(randomX, 2.0f, randomZ);
    }
    public int PrefabsToSpawn { get => prefabsToSpawn; }
}
