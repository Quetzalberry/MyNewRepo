/*
* Denver Heneghan
* Weapon
* Assignment 6 Easy
* This script initializes damageBound and EnemyHoldingWeapon. It gets the script enemy, and assigns EnemyHoldingWeapon to whatever object the
* enemy script is attached to. This script also initializes the voids EnemyEatsWeapon and Recharge.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy EnemyHoldingWeapon;

    private void Awake()
    {
        EnemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(EnemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy Eats Weapon.");
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon.");
    }
}
