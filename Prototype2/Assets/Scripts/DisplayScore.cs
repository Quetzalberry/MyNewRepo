/*
* Denver Heneghan
* DisplayScore
* Prototype 2
* This code takes the text object and sets it so it will display Score: 0 at the start of each scene. Then when it receives an update from
* DetectCollisions, it will change the text object to say Score: and whatever the new score is.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    }
}
