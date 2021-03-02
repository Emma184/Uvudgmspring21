using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //tells where the start position is on the background
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //gets the info for the start position
        startPos = transform.position;
        // finds out what 1/2 the background size on the x axis
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //tells it when to repeat
        if (transform.position.x < startPos.x - repeatWidth)
        {
            // tells it to go back
            transform.position = startPos;
        }  
    }
}
