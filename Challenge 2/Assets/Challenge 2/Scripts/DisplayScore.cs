/*
* Denver Heneghan
* DisplayScore
* Challenge 2
* This script displays the text object with the words Score: 0 in it. When the score is changed, the script updates the text object so it says
* the new score. This script also has the win condition. If the score reaches five, the script tells the player that they win. It also allows 
* the player to restart the game by pressing R. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Set text component reference on start.
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            textbox.text = "You Win! Press R To Play Again.";

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
