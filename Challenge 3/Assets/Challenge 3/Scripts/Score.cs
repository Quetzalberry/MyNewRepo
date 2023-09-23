/*
* Denver Heneghan
* Score
* Challenge 3
* I added this script to keep track of the score. The score is set to zero, and the textbox is called. The script calls
* the textbox from unity and sets it to say "Score: 0" at the start. Then when the player starts collecting money, the player 
* controller script will add one to the int score. The textbox is then changed to say Score: and whatever the updated number
* is. If the score reaches thirty, the text box will change to "You Win" and tell the player to restart the scene by pressing R.
* The script is also called the player control script command gameOver. This way the score script can check if gameOver is true or
* false. If gameOver in the playercontroller script is set to true, which happens when the balloon collides with a bomb, 
* the text box is changed to say "You Lose" and tells the player to restart by pressing R. Finally, this script allows the 
* player to rest the scene when they press R, but only if gameOver is true or the score reaches thirty.
*/
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

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();

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


            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
