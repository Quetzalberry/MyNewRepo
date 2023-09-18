/*
* Denver Heneghan
* PlayerControllerX
* Challenge 2
* For this script, I added a timer. I set the timer for half a second. Once a dog is spawned, the timer needs to reach zero before it can
* be spawned again. This way the player can not rapidly spawn dogs. The player needs to wait 0.5 seconds to spawn the next dog.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time = 0.5f;
    public float timer = Time.time;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= time)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Dog();
                timer = 0;
            }
        }
    }

    void Dog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
