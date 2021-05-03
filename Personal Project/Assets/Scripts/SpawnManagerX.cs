using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // start off spawn manager script so that i can actually finish the quiz and start unit 5
    public GameObject candyPrefab;
    public GameObject enemyPrefab;
    private float spawnRangex = 30;
    private float spawnRangez = 30;
    private PlayerControllerX playerControllerScript; 
    private float spawnInterval = 5.0f;
    private Vector3 spawnPos = new Vector3(19, 13);
    public int objectCount;
    private int objectCap =9;
    

    // Start is called before the first frame update 
    void Start()
    {
        InvokeRepeating("SpawnObject", 0, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        
    }
    private void SpawnObject()
    {      
            // Spawn obstacles 
            // If game is still active, spawn new object 
            if (playerControllerScript.gameOver == false && objectCount < 5)
            { // Set random spawn location and random object index

                Instantiate(candyPrefab, GenerateRandomSpawns(), candyPrefab.transform.rotation);
        
                Instantiate(enemyPrefab, GenerateRandomSpawns(), candyPrefab.transform.rotation);
            objectCount++;
            if (objectCount >= objectCap)
            {
                CancelInvoke("Spawn");
            }
            }


        
       
    }


    private Vector3  GenerateRandomSpawns()
    {
        float spawnPosX = Random.Range(-spawnRangex, spawnRangex);
        float spawnPosZ = Random.Range(-spawnRangez, spawnRangez);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
         return randomPos;
    }
    
}
