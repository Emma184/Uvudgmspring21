using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    private float speed = 20.0f;
    public float xRange = 24;
    public GameObject projectilePreFab;

    // Update is called once per frame
    void Update()
    {
        //tell it where to get movement info
        hInput = Input.GetAxis("Horizontal");

        // sets constraints on the right side
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(24, transform.position.y, transform.position.z);
        }

        //sets constraints on the left side
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-24, transform.position.y, transform.position.z);
        }

        //tells it how to move, left makes the controlls inverted but i like it
        transform.Translate(Vector3.left * hInput * Time.deltaTime * speed);
    }   
    // supposed to help launch it but it not working yet
        if(Input.GetKeyDown(KeyCode.Space))
        {
        //Launches the projectile
        Instantiate(projectilePreFab, transfom.position, projectilePreFab.transform.rotation);
}
