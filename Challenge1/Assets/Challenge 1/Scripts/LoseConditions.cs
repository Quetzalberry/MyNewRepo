using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseConditions : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51)
        {
            ManageScore.gameOver = true;
        }

        if(transform.position.y > 80)
        {
            ManageScore.gameOver = true;
        }
    }
}
