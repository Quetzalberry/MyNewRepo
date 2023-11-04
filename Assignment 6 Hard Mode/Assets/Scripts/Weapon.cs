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
