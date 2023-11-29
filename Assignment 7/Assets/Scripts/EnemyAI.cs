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
    }
}
