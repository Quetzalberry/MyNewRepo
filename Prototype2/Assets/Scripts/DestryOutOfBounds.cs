using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float bottomBound = -20;

    // Update is called once per frame
    void Update()
    {
        //If food goes out of bounds.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //If animals go out of bounds.
        if (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
