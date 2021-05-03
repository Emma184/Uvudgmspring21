using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
   
    public bool isClear = true;
    public float movementSpeed = 5;
    private Rigidbody playerRb;
    public GameObject Player;
    public bool gameOver = false;



    // Start is called before the first frame update
    void Start()
    {
        //instantiates the player's rigidbody
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move player throu wasd keys
        if (Input.GetKey("w"))
        {
            //moves player forward 
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        
        else if (Input.GetKey("s"))
        {
            // moves player backwards 
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
       
        if (Input.GetKey("a") && !Input.GetKey("d"))
        { 
            // moves player left
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            // moves player right
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // tells you if you collected the candy
            if (other.CompareTag("candy"))
            {
                Destroy(other.gameObject);
                Debug.Log("Candy Collected");
            }
            //for when the player hits the obstacles so they don't go through them
        if (other.CompareTag("obstacles"))
        {
            Debug.Log("boop");
            // supposed to stop player from phasing through the walls 
            Rigidbody obstacleRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 boopPlayer = transform.position + other.gameObject.transform.position;
            obstacleRigidbody.AddForce(boopPlayer * 2, ForceMode.Impulse);
            
        }
        // for when the player gets close to an enemy
            if (other.CompareTag("enimies"))
            {
            //got idea from challenge 4
               ResetPlayerPosition();
                Debug.Log("Raccoon attack");

            }
    }
   //got inspiration from challenge 4
    private void ResetPlayerPosition()
    {
        Player.transform.position = new Vector3(1,1,18);

    }
}
