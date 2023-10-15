using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TMP_Text scoreText;

    public int points = 0;

    void Start()
    {
        scoreText.text = "Score: " + points.ToString();
    }

    public void increasePoints()
    {
        points = points + 1;
        scoreText.text = "Score: " + points.ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            increasePoints();
        }
    }
}
