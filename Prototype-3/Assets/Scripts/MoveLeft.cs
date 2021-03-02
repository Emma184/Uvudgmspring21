using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    
    void Start()
    {
        // finds and stores player controller script info for game over
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       //checks if the statement is false or true, if false the script will run
        if (playerControllerScript.isGameOver == false)
        {
            //tells it to move
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        
       
    }
}
