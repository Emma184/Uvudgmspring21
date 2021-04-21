﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 30;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //makes the enemy move towards the player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce( lookDirection * speed * Time.deltaTime);
        if(transform.position.y < -15)
        {
            Destroy(gameObject);
        }

    }
}
