/*
* Denver Heneghan
* EnemyParentClass
* Assignment 6 Easy
* This is a parent class to the two child classes. It calls the script restart, and adds the script to the objects this script is attached to. It also creates
* the abstract void collide to be used in the child classes.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class EnemyParentClass : MonoBehaviour
{
    Restart restart;

    protected virtual void Awake()
    {
        restart = gameObject.AddComponent<Restart>();
    }

    public abstract void Collide();
}
