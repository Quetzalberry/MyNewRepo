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

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        //Add a force upwards multiplied by a randomized speed.
        targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);

        //Add a torque (rotational force) with randomized xyz values.
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        //Set the position with a randomized X value.
        transform.position = new Vector3(Random.Range(-4, 4), -6);
    }

    void Update()
    {
        
    }
}
