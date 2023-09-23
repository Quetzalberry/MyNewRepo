/*
* Denver Heneghan
* DetectCollisionsX
* Challenge 2
* This script detects collisions. When the prefab dog connects with the three ball prefabs the ball will be destroyed. Then score will
* increase by 1.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectCollisionsX : MonoBehaviour
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
    }
}
