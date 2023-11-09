/*
* Denver Heneghan
* GameManager
* Assignment 6 Easy
* (Describe, in general, the code contained.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;

    //A variable to keep track of what level we are on.
    private string CurrentLevelName = string.Empty;

/*    #region This code makes this class a singleton.
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
*/
   
    //Methods to load and unload scenes.
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to load level " + levelName);
            return;
        }

        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to unload level " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        
        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to unload level " + CurrentLevelName);
            return;
        }
    }

    //Pausing and unpausing.
    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }
}
