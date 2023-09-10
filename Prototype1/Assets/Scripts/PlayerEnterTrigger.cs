/*
 * Denver Heneghan
 * Assignment 2, Prototype 1
 * PlayerEnterTrigger
 * This script caused the score to go up when the player entered the trigger zone. It was attached to the player, instead of
 * the trigger zone. It caused the score to go up to three immediately, and was not used in the final version of prototype 1.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to the player.

public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
