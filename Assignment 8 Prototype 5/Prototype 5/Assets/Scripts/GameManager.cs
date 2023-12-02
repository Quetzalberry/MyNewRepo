using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    private int score;

    void Start()
    {
        StartCoroutine(SpawnTarget());

        score = 0;

        UpdateScore(0);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (true)
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
    }
}
