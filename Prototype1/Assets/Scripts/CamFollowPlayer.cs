/*
 * Denver Heneghan
 * Assignment 2, Prototype 1
 * This script allowed the camera to follow the player object.
 * It also made sure the camera was a bit behind the player object, and not directly on top of it.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}