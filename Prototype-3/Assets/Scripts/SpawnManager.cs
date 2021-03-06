﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    //tells it where to spawn
    private Vector3 spawnPos = new Vector3(25,0,0);
    //tells when to spawn
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;

    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

  
    void SpawnObstacle()
    {  //tells it when to run the bellow script
        if (playerControllerScript.isGameOver == false)
        {
            // tells what obstacles to pick
       //want to randomize the obatacle use- GameObject[]-some s's to the word obstaclePrefab - int obstaclePicker = Random.Range(0, obstaclePrefabs.Length); - but this also runs into a problem.
        //tells it to spawn and how
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        }
       
    }

}
