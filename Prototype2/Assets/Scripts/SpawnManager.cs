/*
* Denver Heneghan
* SpawnManager
* Prototype 2
* This script manages the spawning of prefabs. It also sets the boundaries for the player character and the other game objects.
* This script also calls HealthSystem, so that the prefabs can be affected by the health system script.
* Once the game is started, the script will start spawning prefabs of the animal objects added to the game. The code will spawn the a random
* animal from the three choices at a random position on the top boundary. There is a three second interval before they start spawning, then
* they are spawned with a random delay between each spawn. The delay can be anything from 0.8 to 3 seconds long. There is also code that
* would allow the animals to be spawned when the player presses S, but this code went unused in the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Set this array of references in the inspector.
    public GameObject[] prefabsToSpawn;

    //Varibles for spawn position.
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;

    private void Start()
    {
        //Get a reference to the health system script.
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //Add a 3 second delay before first spawning objects.
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 3.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab()
    {
        //Pick a random animal.
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //Generate a random spawn position.
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //Spawning our animal.
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
