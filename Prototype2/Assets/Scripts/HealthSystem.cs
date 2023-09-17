/*
* Denver Heneghan
* HealthSystem
* Prototype 2
* This script is responsible for the health system. First it sets gameOver to false.  If health gets to zero or lower, gameOver is set to true.
* If gameOver is true, it calls the gameOver text which tells the player they lose and how they can restart the scene.
* This script also sets the health to the correct number of hearts. This gets rid of any extra hearts.
* The script will display the full hearts at the start of each game. 
* Once the player starts losing lives, the script starts showing empty hearts in place of the full hearts. 
* The script also checks if the current amount of full hearts on screen is equal to the max amount of full hearts total.
* Then the script creates TakeDamage and AddMaxHealth to be used by other scripts. 
* Finally, the script lets the player restart the scene by pressing R.
*/


//This script is based on https://www.youtube.com/watch?v=3uyolYVsiWc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public List<Image> hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public bool gameOver = false;

    public GameObject gameOverText;

    void Update()
    {
        //If health is somehow more than max health, set health to max health
        if (health > maxHealth)
        {
            health = maxHealth;
        }


        for (int i = 0; i < hearts.Count; i++)
        {
            //Display full or empty heart sprite based on current health
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            //Show the number of hearts equal to current max health
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }

    public void TakeDamage()
    {
        health--;
    }

    public void AddMaxHealth()
    {
        maxHealth++;
    }


}
