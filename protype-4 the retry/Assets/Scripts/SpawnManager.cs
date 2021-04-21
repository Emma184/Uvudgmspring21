using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int waveNumber = 1;
    public int enemyCount;
    public GameObject powerupPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //spawn an enemy
        SpawnEnemyWave(waveNumber);
        // spawns powerups for player to yeet the enemies
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
       
    }
    void Update()
    {
        //find how many eneimies are on the field
        enemyCount = FindObjectsOfType<Enemy>().Length;
        // tells it when it can spawn enemies, with increasing number
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            // spawns more powerups for the player to yeet the enemies with
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        //tells it where it can spwan enemies
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        
        return randomPos;
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++ )
        {//controlls where they spawn
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
