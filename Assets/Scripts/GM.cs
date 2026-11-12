using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    private float spawnLimitXLeft = -9f;
    private float spawnLimitXRight = 9.3f;
    private float spawnPosY = -9f;
    
    private float StartDelay = 2;
    private float SpawnInterval = 1.5f;
    void Start()
    {
    InvokeRepeating("SpawnRandomPellet", StartDelay, SpawnInterval);
    }
    public GameObject[] pelletPrefabs;
    private float spawnRangeX = 9f;
    private float spawnPosZ = 9.7f;
    // Update is called once per frame
    void Update()
    {
    
    }
    void SpawnRandomPellet()
    {
         //randomly generate animal index and spawn position
    int pelletIndex = Random.Range(0, pelletPrefabs.Length);
    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),12f, Random.Range(-spawnPosZ, spawnPosZ));
    Instantiate(pelletPrefabs[pelletIndex], spawnPos, pelletPrefabs[pelletIndex].transform.rotation);  
    }
}