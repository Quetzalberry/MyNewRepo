/*
* Denver Heneghan
* UIManager
* Prototype 3
* This script keeps track of the score, and displays it on screen. The score is increased by one by the TriggerZoneAddScore 
* script. This script also accesses the PlayerController script. This allows this script to access the gameOver command. 
* If the gameOver command is set to true by the PlayerController script, and the score doesn't equal ten, then the text 
* will display the words "You Lose!" If the score is at ten when the gameOver is set to true, then the text will say
* "You Win!" This script also checks if the text box in unity has any text in it. If it doesn't the text box is set to display
* "Score: 0" at the start of the game. Finally the script allows the player to press R to restart the scene if the player wins
* or loses.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public bool won = false;

    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //Display score until game is over.
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //Loss Condition: Hit the obstacle.
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R To Try Again!";
        }

        //Win Condition: 10 points.
        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;

            //Stop player from running.

            scoreText.text = "You Win!\nPress R To Try Again!";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
