﻿/*
* Denver Heneghan
* (File Name)
* Prototype 2
* (Describe, in general, the code contained.)
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
