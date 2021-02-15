using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    
  

    // Start is called before the first frame update
    void Start()
    {
         int spawnInterval = Random.Range(3, 6);
        InvokeRepeating("SpawnRandomBall", startDelay, 0f);
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
   
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballpicker = Random.Range(0, ballPrefabs.Length);
        // to vary the spawn time
        float spawnInterval = Random.Range(3, 5);
        Debug.Log(spawnInterval);
        Invoke("SpawnRandomBall", spawnInterval);
        
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballpicker], spawnPos, ballPrefabs[ballpicker].transform.rotation);
        
    }

}
