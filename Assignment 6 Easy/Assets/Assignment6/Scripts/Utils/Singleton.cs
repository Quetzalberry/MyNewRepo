/*
* Denver Heneghan
* Singleton
* Assignment 6 Easy
* This script returns the instance variable. It also checks if the instance variable equals null. If an object is destroyed, the script sets 
* instance as null so another object can be created. If it is not null, then the script tries to instantiate a second instance of a singleton class.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T>: MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    public static bool IsInitialized
    {
        get
        {
            return instance != null;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("[Singleton] Trying to instantiate a second instance of a singleton class.");
        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        //If this object is destroyed, make instance null so another can be created.
        if (instance == this)
        {
            instance = null;
        }
    }
}
