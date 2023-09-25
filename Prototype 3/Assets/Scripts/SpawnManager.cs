/*
* Denver Heneghan
* SpawnManager
* Prototype 3
* This script is used to spawn the obstacles in the game. It repeatedly spawns the prefabs of the obstacles 
* at a specific vector every two seconds. It also gives a two second delay when the first obstacle is spawned. This script also
* accesses the PlayerController script. If the object gameOver from the PlayerController script is set to true, then the 
* script will stop spawning obstacles.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(30, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
    }

    void spawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
