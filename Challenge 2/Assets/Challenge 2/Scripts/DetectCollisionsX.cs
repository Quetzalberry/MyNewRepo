/*
* Denver Heneghan
* DetectCollisionsX
* Challenge 2
* This script detects collisions. When the prefab dog connects with the three ball prefabs the ball will be destroyed. Then score will
* increase by 1. I also attempted to create a win condition. If the dog prefab connects with the ball prefabs, then keepscore will go up.
* Once keepscore reaches five, the text you win should be displayed. The text is turned off at the start of the scene and it should be turned
* back on once the win condition is met. While the text is successfully turned off, I was unable to get it to display again after the score 
* reached five points.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    public Text gameWonText;
    public int keepscore = 0;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();

        gameWonText.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        keepscore++;

        if (keepscore == 5)
        {
            gameWonText.enabled = true;
        }
    }
}
