using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //info and data on what to follow
    public GameObject plane;
    private Vector3 offset = new Vector3( 30,0,10);


    // Update is called once per frame
    void Update()
    {
        // how to follow plane
        transform.position = plane.transform.position + offset;
    }
}
