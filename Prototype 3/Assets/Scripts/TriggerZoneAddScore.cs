/*
* Denver Heneghan
* TriggerZoneAddScore
* Prototype 3
* This script sets the bool triggered to false, then accesses the UIManager script. When the trigger zones in unity collide 
* with objects with the tag player, it will turn trigger into true and accesses the int score from the UIManager scrip and 
* increase it by one.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
