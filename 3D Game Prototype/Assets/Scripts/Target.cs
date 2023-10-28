/*
* Denver Heneghan
* Target
* 3D Game Prototype
* This script sets the hearth float to 50. If the void TakeDamage is called, then a specified amount is taken away from the float health.
* If the health float reaches 0, then the void Die is called. This void destroys the game object.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
