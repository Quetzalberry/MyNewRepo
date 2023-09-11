/*
 * Denver Heneghan
 * Assignment 2, Challenge 1
 * AddScoreOnce
 * This script increases the score by 1 every time the player touches a trigger zone. Once the score reaches 5, triggered is
 * confirmed to be true, and this lets ManageScore print out "You Win!"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ManageScore.score++;
        }
    }
}
