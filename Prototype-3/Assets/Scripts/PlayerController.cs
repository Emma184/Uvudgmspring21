﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;

    public bool isOnGround = true;
    public bool isGameOver = false;

    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        //
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // tells it how and when to have the player jump
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // stops the player from spamming space
            isOnGround = false;
            // allows both the run and jump animation to be a thing.
            playerAnim.SetTrigger("Jump_trig");

         
        }
        
    }
    //
    private void OnCollisionEnter(Collision collision)
    
    {
       

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("Grounded");
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }

}

