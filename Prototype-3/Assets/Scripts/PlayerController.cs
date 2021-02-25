using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    public bool isOnGround = true;


    // Start is called before the first frame update
    void Start()
    {
        //
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;
       
    }

    // Update is called once per frame
    void Update()
    {
        // tells it how and when to have the player jump
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // stops the player from spamming space
            isOnGround = false;
        }
        
    }
    //
    private void OnCollisionEnter(Collision other)
    
    {
        isOnGround = true;
    }
}

