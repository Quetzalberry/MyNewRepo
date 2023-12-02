/*
* Denver Heneghan
* GameManager
* Assignment 8 Prototype 5
* This script manages the difficulty. It divides the speed by the difficulty assigned to each button so that the level spawns objects faster
* depending on which button is pressed. This script also controls the restart button that is used to reload the scene when it is clicked. 
* The restart button and the game over text are hidden at the beginning of the game, but are shown when the game is lost. The title screen 
* hold the title text and the three difficulty buttons, and it is hidden once one of the buttons is clicked. This script also keeps track of 
* the score. The score goes up or down by a specific number depending on which object is clicked. Finally this script controls were the objects
* will spawn in the game by accessing the Target script and the code in it.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    private int score;

    public bool isGameActive;

    public Button restartButton;

    public GameObject titleScreen;

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;

        isGameActive = true;

        StartCoroutine(SpawnTarget());

        score = 0;

        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            //Wait 1 second.
            yield return new WaitForSeconds(spawnRate);

            //Pick a random index between 0 and the number of prefabs.
            int index = Random.Range(0, targets.Count);

            //Spawn the prefab at the randomly selected index.
            Instantiate(targets[index]);
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }
}
