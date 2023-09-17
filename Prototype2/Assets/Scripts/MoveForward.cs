/*
* Denver Heneghan
* MoveForward
* Prototype 2
* This script is applied to the animals in the game. It sets their speed at 40. Then the script tells them to move forward at that speed.
* The speed of the animals was changed in unity.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
