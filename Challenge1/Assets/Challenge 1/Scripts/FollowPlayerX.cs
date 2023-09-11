/*
 * Denver Heneghan
 * Assignment 2, Challenge 1
 * FollowPlayerX
 * This script starts the camera at a specific location, and rotates the camera, so it is looking at the plane from the side at a distance.
 * The script also makes sure the camera follows the player object when it moves.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
