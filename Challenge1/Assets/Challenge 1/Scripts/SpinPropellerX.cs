/*
 * Denver Heneghan
 * Assignment 2, Challenge 1
 * SpinPropellerX
 * This script causes the child object propeller to spin repeatedly on the z axis. 
 * It also sets the rotation speed of propeller to 200. 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    int rotationSpeed = 200;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
