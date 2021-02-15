using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    // tells it where to get the animals
    public GameObject[] animalPrefabs;
    //tells it where to spawn animals
    private float SpawnRangeX = 20;
    private float SpawnPosZ = 20;
    //tells it how to spawn the animals
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //starts the spawning
        InvokeRepeating("SpawnRandomAnimals", startDelay,spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimals()
    {
        //Randomly Generates animal spawn position and animal type
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        int animalpicker = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalpicker], spawnPos, animalPrefabs[animalpicker].transform.rotation);
    }
}
