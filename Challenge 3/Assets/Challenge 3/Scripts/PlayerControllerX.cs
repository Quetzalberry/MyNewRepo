/*
* Denver Heneghan
* PlayerControllerX
* Challenge 3
 I added the public bool isLowEnough to the script and set it to true. I then set it so that if isLowEnough is true,
* the player can press space to move the balloon upwards. If the balloon goes above 15 on the y axis, isLowEnough is set
* to false. It is set to true again once the balloon is back below 15 on the y axis. This prevents the player from going
* too high. I also added the rigid body component so that it would be able to connect with the ground. If the balloon collides
* with the ground the balloon is forced upwards. This is so the balloon does not sink too low. I also added the boing sound effect
* and set it so it plays when the balloon collides with the ground. Finally I added called the script Score and set it as 
* addToScore. By calling the script Score, it allows this script to interact with it. If the balloon collides with money objects
* the int score is called from the Score script, and it is increased by one. This allows the score in the game to increase 
* every time the player collects points.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Score addToScore;

    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip boingSound;

    public bool isLowEnough = true;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        playerRb = GetComponent<Rigidbody>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

        addToScore = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && isLowEnough == true)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }

        if (transform.position.y > 15)
        {
            isLowEnough = false;
        }
        else
        {
            isLowEnough = true;
        }

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
            addToScore.score++;
        }

        else if (other.gameObject.CompareTag("Ground"))
        {
            playerRb.AddForce(Vector3.up * 15, ForceMode.Impulse);
            playerAudio.PlayOneShot(boingSound, 1.0f);
        }

    }
}
