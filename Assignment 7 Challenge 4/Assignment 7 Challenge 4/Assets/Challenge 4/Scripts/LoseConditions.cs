/*
 * Denver Heneghan
 * LoseConditions
 * Assignment 7 Challenge 4
 * This script checks if the enemy has collided with the player's goal. If it has, then the you lose text pops up, and the player needs to
 * hit R to restart the level. 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseConditions : MonoBehaviour
{
    public Text Lose;

    void Start()
    {
        Lose.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            Lose.enabled = true;
            Time.timeScale = 0f;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
