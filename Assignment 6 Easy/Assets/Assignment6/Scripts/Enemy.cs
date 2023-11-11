/*
* Denver Heneghan
* Enemy
* Assignment 6 Easy
* This script sets speed to 5, health to 100, and damageBouns to 10. It calls the damageBounus from the weapon script. It also adds the weapon
* script to the game object that the enemy script is attached to. All of that happens in the Awake void. This script also sets two abstract empty
* voids that can be called by child classes of the enemy class. This script also calls the SerializedField to get data from the weapon script.
* This script also calls the IDamageable script at the beginning of the class so the TakeDamage void from that script can be used in the enemy 
* script.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable
{
    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();

        speed = 5f;
        health = 100;

        weapon.damageBonus = 10;
    }

    protected abstract void Attack(int amount);

    public abstract void TakeDamage(int amount);
}
