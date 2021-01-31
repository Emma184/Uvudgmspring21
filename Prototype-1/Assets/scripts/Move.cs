using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Access Modifier, Data Type, Name
    private float speed = 25.0f;
    private float turnSpeed = 30.0f;

    private float hInput;
    private float fInput;

    // Update is called once per frame
    void Update()
    {
        // gathers the inputs for the controls (basically tells it what buttons are going to control it)
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        // makes car go forward and back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        // makes car go left and right
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}
