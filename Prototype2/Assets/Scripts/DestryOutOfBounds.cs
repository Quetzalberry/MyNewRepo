﻿/*
* Denver Heneghan
* DestryOutOfBounds
* Prototype 2
* This script sets a boundary at the top and bottom of the screen. Then it destroys any prefabs that cross that boundary.
* It also calls the health system script. If the prefabs cross the boundary at the bottom of the screen, the health system script is called.
* This means the code in that script is executed. Then the player takes damage and loses a life. There is also unused code that calls the 
* words Game Over.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float bottomBound = -20;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //If food goes out of bounds.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //If animals go out of bounds.
        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");

            //Grab the health system script and call the TakeDamage method.
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
