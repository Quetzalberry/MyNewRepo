/*
 * Denver Heneghan
 * Assignment 2, Challenge 1
 * ManageScore
 * This script prints out Score: 0 at the top left hand side of the screen. When the score is 5 or greater, it prints out "You Win!"
 * If the plane goes out of bounds, gameOver is confirmed to be true by the script LoseConditions, and prints out "You Lose!"
 * This script also allows the player to reset the scene by pressing R. 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManageScore : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to Try Again!";
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
