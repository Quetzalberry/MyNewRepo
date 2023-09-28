using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GardenPlot")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "bag")
        {
            Destroy(gameObject);
        }
    }
}


