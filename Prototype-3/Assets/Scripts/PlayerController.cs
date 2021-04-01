using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;

    public bool isOnGround = true;
    public bool isGameOver = false;
    //animation stuff
    private Animator playerAnim;
    //particle stuff
    public ParticleSystem dirtParticles;
    public ParticleSystem explosionParticles;
    //music and sound stuff
    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;

    


    // Start is called before the first frame update
    void Start()
    {
        //
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // tells it how and when to have the player jump
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // stops the player from spamming space
            isOnGround = false;
            // allows both the run and jump animation to be a thing.
            playerAnim.SetTrigger("Jump_trig");
            dirtParticles.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);

         
        }
        
    }
    // player collision controlls
    private void OnCollisionEnter(Collision collision)
    
    {
       
        //tells if the player is on ground controlls the dirt
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("Grounded");
            dirtParticles.Play();
        }

        //tells if the player hits an obsticle and will end the game and starts explosion particles
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticles.Play();
            dirtParticles.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }

}

