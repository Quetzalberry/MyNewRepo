/*
 * Denver Heneghan
 * Assignment 2, Prototype 1
 * TriggerZoneAddScoreOnce
 * This script is attached to a trigger zone. When the player touches a trigger zone,
 * this script makes the score go up by one. It also makes sure the score goes up only once per trigger zone.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a trigger zone.

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
