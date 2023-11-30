/*
* Denver Heneghan
* SpawnManager
* Assignment 7 (Prototype 4)
* This script spawns the enemies and the powerups. On starting the game, one enemy and one powerup is spawned. After each wave, the amount
* of enemies and powerups spawned each level increases by one. This script also keeps track of which wave the player is on, and displays
* it through text. If the player beats the 10th wave, then they have won the game, and the you win text is displayed.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float spawnRange = 9;

    public int enemyCount;
    public int waveNumber = 1;

    public Text win;

    public Text wave;

    void Start()
    {
        SpawnEnemyWave(waveNumber);

        SpawnPowerup(1);

        win.enabled = false;

        wave.text = "Wave: " + waveNumber;
    }

    private void SpawnPowerup(int powerupsToSpawn)
    {
        for (int i = 0; i < powerupsToSpawn; i++)
        {
            //Instantiate the powerup in the random position.
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            //Instantiate the enemy in the random position.
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    private void Update()
    {
        wave.text = "Wave: " + waveNumber;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount == 0)
        {
            waveNumber++;

            SpawnEnemyWave(waveNumber);

            SpawnPowerup(1);
        }

        if (waveNumber >= 11)
        {
            win.enabled = true;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
