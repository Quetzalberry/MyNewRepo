/*
* Denver Heneghan
* UIManager
* Prototype 3
* 
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
