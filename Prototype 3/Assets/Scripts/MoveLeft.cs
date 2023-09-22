using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    private float leftBound = -15;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //If we are out of bounds to the left and this game object is an obstacle, destroy this game object.
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"));
        {
            Destroy(gameObject);
        }
    }
}
