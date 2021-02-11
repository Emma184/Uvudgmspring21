using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed = 20.0f;
    

    // Update is called once per frame
    void Update()
    {
        //tell it where to get movement info
        hInput = Input.GetAxis("Horizontal");

        // sets constraints on the right side
        if(transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }

        //sets constraints on the left side
        if(transform.position.x < -15)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }

        //tells it how to move, left makes it inverted but i like it
        transform.Translate(Vector3.left * hInput * Time.deltaTime * speed);
    }   
}
