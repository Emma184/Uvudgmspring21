using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
   
    public bool isClear = true;
    public float movementSpeed = 5;
    private Rigidbody playerRb;
    public GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {//moves player forward 
        if (Input.GetKey("w"))
        {

            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed; }
        // moves player backwards 
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        // moves player left
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        // moves player right
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        
        }
    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Candy"))
            {
                Destroy(other.gameObject);
                Debug.Log("Candy Collected");
            }
    }
}
