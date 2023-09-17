/*
* Denver Heneghan
* PlayerController
* Prototype 2
* This script allows the player character to move in game. The character's speed is set to 10, and the side boundaries 
* are set to 14 and -14 along the x axis. The first input allows the player to move horizontally. The player character can be moved left or
* right. Then the code cancels the players ability to move horizontally if they reach one of the side boundaries. The player character can
* still be moved, but the code blocks it at a certain point.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        //Get horizontalInput.
        horizontalInput = Input.GetAxis("Horizontal");

        //Transform horizontally with input.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player in bounds.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
