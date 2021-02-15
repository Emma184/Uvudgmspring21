using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        //destroy object script is attached to
        Destroy(gameObject);
        //destroy other colliding object
        Destroy(other.gameObject);
    }
}
