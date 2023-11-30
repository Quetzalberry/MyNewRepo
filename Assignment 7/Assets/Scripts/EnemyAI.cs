/*
* Denver Heneghan
* EnemyAI
* Assignment 7 (Prototype 4)
* This script controls the enemy AI. It makes the enemies go in the direction of the player character. It also makes the enemy increase in
* force towards the player when it crosses the distance between it and the player. If the enemy goes below -10 on the y axis, it is destroyed.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody enemyrb;
    public GameObject player;
    public float speed = 3.0f;

    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        //Add force towards the direction from the player to the enemy.

        //Vector for direction from enemy to player.

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        //Add force toward player.
        enemyrb.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
