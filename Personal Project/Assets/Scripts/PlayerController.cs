using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //controller for movement  and speed
   
    public float movementSpeed = 5;
   
   
    
 


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    private void FixedUpdate()
    {
        //moves player forward
        if (Input.GetKey("w"))
        {
            
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        // moves player backwards
        else if (Input.GetKey("s"))
        {
            
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        // moves player left
        if(Input.GetKey("a") && !Input.GetKey("d") )
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        // moves player right
        else if(Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;

        }
    }
   void Update()
    {
    }
}
