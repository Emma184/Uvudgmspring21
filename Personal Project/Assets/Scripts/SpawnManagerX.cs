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
    private float spawnDelay = 2; 
    private float spawnInterval = 1.5f;
    private Vector3 spawnPos = new Vector3(19, 13);
    // Start is called before the first frame update 
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();

    }
    private void Update()
    {
         // Spawn obstacles 
    // If game is still active, spawn new object 
        if (playerControllerScript.gameOver == false)
        { // Set random spawn location and random object index
       
            Instantiate(candyPrefab, GenerateRandomSpawns(), candyPrefab.transform.rotation);
            Instantiate(enemyPrefab, GenerateRandomSpawns(), candyPrefab.transform.rotation);

        }
        if ()
        {

        }
        
    }
    private Vector3  GenerateRandomSpawns()
    {
        float spawnPosX = Random.Range(-spawnRangex, spawnRangex);
        float spawnPosZ = Random.Range(-spawnRangez, spawnRangez);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
         return ;
    }
    void DeleteEnemies()
    {

        IEnumerator PowerupCountdownRoutine()
        {
            yield return new WaitForSeconds(20);
            DestroyObject(enemyPrefab);
            
        }
    }
}
