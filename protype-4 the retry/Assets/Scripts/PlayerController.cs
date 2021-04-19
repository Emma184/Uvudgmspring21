using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    //speed and rigidbody 
        private Rigidbody playerRb;
        public float speed;
    //camera focus
        private GameObject focalPoint;
  
    public bool hasPowerup;
    public float powerupStrength = 15;
    public GameObject powerupIndicator;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalPoint");

    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime);
        powerupIndicator.transform.position = transform.position + new Vector3(0, 0.5f, 0);


    }
    // this block of code allows the player to pickup the powerup

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            Debug.Log("Powerup Collected");

            StartCoroutine(PowerupCountdownRoutine());

            powerupIndicator.gameObject.SetActive(true);
        }
      
    }
 private void OnCollisionEnter(Collision collision)
    {  
        if(collision.gameObject.CompareTag("enemy") && hasPowerup)
        {//gets enemies rigidbody to change it's physics properties
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        //gets enimies position compared to player
            Vector3 awayFromplayer = (collision.gameObject.transform.position);
        // tell if the player got the powerup
            Debug.Log("Player hs collided with" + collision.gameObject + "with powerup set to" + hasPowerup);
        // hits enemy back on collision
            enemyRigidbody.AddForce(awayFromplayer * powerupStrength, ForceMode.Impulse);
        }
    }
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7); hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }


}
