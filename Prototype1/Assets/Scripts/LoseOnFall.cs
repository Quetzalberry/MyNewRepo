/*
 * Denver Heneghan
 * Assignment 2, Prototype 1
 * This script makes the game end when the player falls off the road and goes below -1 on the worlds y axis. 
 * It prompts the script ScoreManger text box to print "You Lose!"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to the player.

public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
