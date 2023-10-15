/*
* Denver Heneghan
* DisplayScore
* 2DPixelProject
* This script displays the score on screen. It sets points to 0, then it sets the score text to equal "Score: " + points. This means that the score will show
* whatever number points is. There is a void called increasePoints, and it adds 1 to points when called. Then it prints out the new score text with the new points.
* Then the script detects if the object this script is attached to has collided with an object tagged Player. If it has, it then calls the increaasePoints
* void and executes it. This script is attached to the gem objects.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TMP_Text scoreText;

    public int points = 0;

    void Start()
    {
        scoreText.text = "Score: " + points.ToString();
    }

    public void increasePoints()
    {
        points = points + 1;
        scoreText.text = "Score: " + points.ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            increasePoints();
        }
    }
}
