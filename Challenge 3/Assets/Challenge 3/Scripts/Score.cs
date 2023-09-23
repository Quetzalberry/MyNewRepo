using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text textbox;
    public int score = 0;

    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0";

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>(); //Added

    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if(score >= 30 && !playerControllerScript.gameOver)
        {
            textbox.text = "You Win! Press R To Play Again.";

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if(playerControllerScript.gameOver)
        {
            textbox.text = "You Lose! Press R To Play Again.";


            if (Input.GetKeyDown(KeyCode.R)) //Added
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
