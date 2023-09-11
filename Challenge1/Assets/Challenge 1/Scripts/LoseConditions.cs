/*
 * Denver Heneghan
 * Assignment 2, Challenge 1
 * LoseConditions
 * This script is attached to the player object. If the player object goes above 80 on the y axis, or below -51 on the y axis, then the 
 * script confirms gameOver is true, which allows the ManageScore script to print "You Lose!"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseConditions : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51)
        {
            ManageScore.gameOver = true;
        }

        if(transform.position.y > 80)
        {
            ManageScore.gameOver = true;
        }
    }
}
