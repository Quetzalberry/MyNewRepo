/*
 * Denver Heneghan
 * Assignment 2, Prototype 1
 * This script displays the text box when the player wins or looses. If the player wins, the text box shows the words "You Win!"
 * If the player looses the text box displays the words "You Lose!" The text box also tells the player to press R to restart the game.
 * Another thing this script does is allow the player to restart the game if they press R. Pressing R reloads the scene, and it
 * resets the score back to zero.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
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
        //If the game is not over, display score.
        if(!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //Win condition, 3 or more points.
        if(score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You Win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to Try Again!";
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
