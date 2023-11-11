/*
* Denver Heneghan
* Golem
* Assignment 6 Easy
* This script has a class that inherits from the enemy script. It calls the void Awake from the enemy script, then sets the health to equal 120
* instead of 100 in the golem Awake void. The script also calls the abstract voids Attack and TakeDamage from the enemy script, and applies
* actions to those empty voids. In this case, it applies the Debug.Log action. This way the Golem script can inherit what it needs from the 
* enemy script, and then add new conditions that only apply for the golem script. This script also calls instance.score from the GameManager 
* script, and adds 2 on on Awake.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score += 2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem Attacks.");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + " points of damage.");
    }
}
