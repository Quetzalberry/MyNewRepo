/*
* Denver Heneghan
* RepeatBackgroundX
* Challenge 3
* For this script, I changed the repeatWidth so it was size.x instead of size.z. This allows the background to repeat
* smoothly. It cuts the script in half widthwise and repeats the background with that half.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


