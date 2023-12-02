/*
* Denver Heneghan
* DifficultyButton
* Assignment 8 Prototype 5
* This code gets an int off of the three buttons on the title screen that can be clicked. The int is then used in GameManager to manage the 
* difficulty of the game. It calls voids from GameManager to start the game, and control its difficulty. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;

    private GameManager gameManager;

    public int difficulty;

    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(SetDifficulty);

        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + "was clicked");

        gameManager.StartGame(difficulty);
    }
}
