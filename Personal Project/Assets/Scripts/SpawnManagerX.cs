using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{ 
    // start off spawn manager script so that i can actually finish the quiz and start unit 5
    public GameObject enemyPrefab;
    private float spawnRange = 30;
    public int waveNumber = 1;
   
    public GameObject candyPrefab;
    // Start is called before the first frame update
    void Start()
    {
         //spawn an enemy 
        // spawns powerups for player to yeet the enemies 
        Instantiate(candyPrefab, GenerateSPosition(), candyPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
       
      

    }

    private Vector3 GenerateSPosition()
    {

    }
        //tells it where it can spwan enemies 
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
    }
}
