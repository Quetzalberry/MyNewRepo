/*
* Denver Heneghan
* TriggerZone
* 3D Game Prototype
* This script starts by setting the text object to not be enabled. Then if the object this script is attached to collides with the player object,
* the text object is enabled. This script is attached to the trigger end zone in the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.enabled = true;
        }
    }
}
