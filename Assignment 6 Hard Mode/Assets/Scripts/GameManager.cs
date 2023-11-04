using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    #region This code makes this class a singleton.
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //Make sure this game manager persists across scenes.
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to Instantiate a Second Instance of Singleton Game Manager.");
        }
    }
    #endregion
}
