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

    private void Start()
    {
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //Add a 3 second delay before first spawning objects.
        yield return new WaitForSeconds(3f);

        while (true)
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
