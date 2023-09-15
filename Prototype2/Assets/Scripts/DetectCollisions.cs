using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to food.

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
