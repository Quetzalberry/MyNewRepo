/*
* Denver Heneghan
* PlayerController
* Prototype 3
* This script controls the movement of the player character, as well as the audio, particle effects, and character
* animation. The script gives the player a rigid body so it can interact with other objects like the ground.
* It also makes the player character affected by gravity. If space is pressed, and the character is on the ground, 
* then force is applied to the character to boost it into the air. Gravity will bring the character back down.
* If the character is not on the ground, the space bar does nothing. If the player collides with an obstacle, 
* then gameOver is set to true and the game is stopped. The script also animates the player character. 
* It applies the running animation to the character when the game starts, and it applies the jumping animation when the player
* hits the space bar and is touching the ground. The script also plays the death animation if the player collides with an 
* obstacle. The explosion particle effects and crash sound effect are also applied if the character runs into an obstacle. 
* Dirt particle effects are set when the player starts the game, but they are stopped when the character hits space bar and 
* is in the air. Hitting the spacebar also triggers the jumping sound effect. Finally at the start of the game, an audio clip
* is played. It is set to loop in unity, so it plays indefinitely.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //Set a reference to our rigid body componet.
        rb = GetComponent<Rigidbody>();
        //Set a reference to our Animator component.
        playerAnimator = GetComponent<Animator>();

        //Set reference to audio source component.
        playerAudio = GetComponent<AudioSource>();

        //Start running animation on start.
        playerAnimator.SetFloat("Speed_f", 1.0f);

        forceMode = ForceMode.Impulse;

        //Modify gravity
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Jumping when the player presses space.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;

            //Set the trigger to play the jump animation.
            playerAnimator.SetTrigger("Jump_trig");

            //Stop playing dirt particle on jump.
            dirtParticle.Stop();

            //Play jump sound effect.
            playerAudio.PlayOneShot(jumpSound, 2.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            //Start playing dirt particle when the player hits the ground.
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;

            //Play the death animation.
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //Play explosion particle.
            explosionParticle.Play();

            //Play crash sound effect.
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
