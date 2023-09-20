/*
* Denver Heneghan
* PlayerControllerX
* Challenge 2
* For this script, I added a timer. I set the timer for half a second. Once a dog is spawned, the timer needs to reach zero before it can
* be spawned again. This way the player can not rapidly spawn dogs. The player needs to wait 1.0 seconds to spawn the next dog.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 1.0f;
    private bool countdown = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (countdown == false)
            {
                Dog();
                StartCoroutine(Time());
            }
        }
    }

    IEnumerator Time()
    {
        countdown = true;
        yield return new WaitForSeconds(time);
        countdown = false;
    }

    void Dog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
