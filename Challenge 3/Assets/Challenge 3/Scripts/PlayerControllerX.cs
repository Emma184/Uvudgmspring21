using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //controlls the floating and gravity stuff
    private Rigidbody playerRb;
    public float floatForce;
    public float gravityMod;
    // constrains ballon
    private float topBound = 17;
    private float bottomBound = 0;
   
    public bool gameOver = false;
    //animation effects
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    //music effects 
    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod; 
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * floatForce);
    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        // While space is pressed and player is low enough, float up
        if(Input.GetKey(KeyCode.Space) && !gameOver && transform.position.y < topBound)
        {
            playerRb.AddForce(Vector3.up * 1 / 1.5f, ForceMode.Impulse);
        }
        if(transform.position.x > topBound)
        {
            transform.position = new Vector3(transform.position.x, 24, transform.position.z);
        }

        //sets constraints on the left side
        if(transform.position.x < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }

        private void OnCollisionEnter(Collision other) 
        { 
            // if player collides with bomb, explode and set gameOver to true
            if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }}
           

    }

}
