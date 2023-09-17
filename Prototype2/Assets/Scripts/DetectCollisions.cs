/*
* Denver Heneghan
* DetectCollisions
* Prototype 2
* The first thing this code does is display the score. It does this by finding the object tagged with DisplayScoreText.
* The score is in the top left corner, and it starts at zero. After that, the script detects if two objects have collided with each other.
* If the object the player is shooting collides with another object, then one point is added to the score,
* then both objects are destroyed. The code will then display the new score.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to food.

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
