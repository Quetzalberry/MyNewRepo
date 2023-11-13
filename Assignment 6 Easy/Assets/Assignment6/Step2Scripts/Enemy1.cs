/*
* Denver Heneghan
* Enemy1
* Assignment 6 Easy
* This is a child class of the parent class EnemyParentClass. This class calls the void Awake from the parent class. Then if the object this script is attached to
* collides with the object tagged as player, it calls the collide void. The collide void with print something in the Debug.Log telling the player they have collided
* with box type 1.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : EnemyParentClass
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void Collide()
    {
        Debug.Log("You have hit box type 1. Try again.");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collide();
        }
    }
}