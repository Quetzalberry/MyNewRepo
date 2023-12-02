/*
* Denver Heneghan
* Target
* Assignment 8 Prototype 5
* This script spawns the objects at a random place, at a random speed, with a random amount of torque. This script also destroys those objects
* when they are clicked, and also causes a particle effect to appear when the object is clicked. This script also activates the game over
* void in GameManager if an object that is not tagged as "Bad" touches the trigger zone. Finally, this script initializes the rigidbodies
* of the objects.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;

    private GameManager gameManager;

    public int pointValue;

    public ParticleSystem explosionParticle;

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        //Add a force upwards multiplied by a randomized speed.
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);

        //Add a torque (rotational force) with randomized xyz values.
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //Set the position with a randomized X value.
        transform.position = RandomSpawnPos();

        //Set reference to game manager.
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

            gameManager.UpdateScore(pointValue);

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }

        Destroy(gameObject);
    }
}
