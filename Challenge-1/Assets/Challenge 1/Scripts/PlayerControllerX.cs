using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //basic needed info
    private float speed = 10.0f;
    private float turnSpeed = 1.0f;
    private float rInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        rInput = Input.GetAxis("Vertical");
       

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * turnSpeed * rInput);
       
    }
}
