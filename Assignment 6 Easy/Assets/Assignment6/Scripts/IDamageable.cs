/*
* Denver Heneghan
* IDamageable
* Assignment 6 Easy
* This script sets the empty void TakeDamage. This allows the void to be used in another script as an abstract void.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int amount);
}
