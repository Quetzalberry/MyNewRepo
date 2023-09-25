/*
* Denver Heneghan
* RepeatBackground
* Prototype 3
* This script is used to repeat the background when it is being moved left. It cuts the background in half widthwise. This way
* when the background is deleted when it moves to far left, only half of it will be deleted. The script sets the starting position
* as a vector, and resets the background to this starting vector if it moves to far left. This means the background keeps being
* deleted and rest, which gives it the impression that it goes on forever.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //Save the starting position as a Vector3.
        startPosition = transform.position;

        //Set the repeatWidth to half of the width of the background.
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //If the background is farther to the left than the repeatWidth, reset it to its start position.
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
