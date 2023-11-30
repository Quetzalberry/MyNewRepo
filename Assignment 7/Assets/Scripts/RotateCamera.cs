/*
* Denver Heneghan
* RotateCamera
* Assignment 7 (Prototype 4)
* This script allows the player to rotate the camera to the left or right with the left and right arrow keys.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
