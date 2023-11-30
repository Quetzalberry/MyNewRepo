/*
* Denver Heneghan
* PlayerController
* Assignment 7 (Prototype 4)
* This script controls the movement of the player character. The player can move the player back and forth using the up and down arrow keys.
* It also focuses on a focal point so what the player character considers up and down is dependent on the position of the camera and its focal
* point. This script also shows the tutorial text telling the player what to do. Once space is hit, the text disappears, and the game starts.
* If the player falls below -3 on the y axis, the you lose text is displayed and the game is paused. This script also allows the player and 
* enemies to bounce off each other. This script also handles powerups. If the player collides with a powerup, the powerup disappears, a 
* the power up indicator is shown for 7 seconds, and for 7 seconds, the enemies bounce off the player to further away. After 7 seconds, this is
* stopped.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRB;
    public float speed;
    private float forwardInput;

    private GameObject focalPoint;

    public bool hasPowerup;

    private float powerupStrength = 15.0f;

    public GameObject powerupIndicator;

    public Text lose;
    public Text tutorial;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");

        lose.enabled = false;

        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        //Move our powerup indicator to the ground below our player.
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tutorial.enabled = false;
            Time.timeScale = 1f;
        }

        if (transform.position.y < -3)
        {
            lose.enabled = true;
            Time.timeScale = 0f;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void FixedUpdate()
    {
        PlayerRB.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Debug.Log("Player collided with " + collision.gameObject.name + " with powerup set to " + hasPowerup);

            //Get a local reference to the enemy rb.
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            //Set a Vector3 with a direction away from the player.
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;

            //Add force away from player.
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}
