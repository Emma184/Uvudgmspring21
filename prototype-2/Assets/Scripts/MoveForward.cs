using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 15.0f; 

  

    // Update is called once per frame
    void Update()
    {
        // tells the bone to move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
