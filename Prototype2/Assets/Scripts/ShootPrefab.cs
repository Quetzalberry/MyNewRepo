/*
* Denver Heneghan
* ShootPrefab
* Prototype 2
* This code creates the game object prefabToShoot. Then if the space bar is pressed, the game object is called and
* the object the script is applied to will be shot forward. This script is applied to the food prefab.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
