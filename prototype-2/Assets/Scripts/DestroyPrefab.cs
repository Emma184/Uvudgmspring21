using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    //tells it what are the limits
    private float topBound = 35;
    private float lowerBound = -16;
    

    // Update is called once per frame
    void Update()
    {
        //lets it know what to do and when to do it
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
