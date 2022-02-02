using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 10;
    private float delayTime = 1;
    private float spawnInterval = 0.5f;
    private object clone;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemies", delayTime, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomEnemies()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 5.5f, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);


    }
}
