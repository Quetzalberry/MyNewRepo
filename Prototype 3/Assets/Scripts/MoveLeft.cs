/*
* Denver Heneghan
* MoveLeft
* Prototype 3
* This script continuously moves the background and obstacle prefabs left at a speed of thirty. It also sets a boundary at 
* negative fifteen on the x axis. It accesses the object gameOver from the PlayerContoller script. 
* If gameOver is false, then the objects this script is attached to will be moved left. If those objects pass negative fifteen,
* they are destroyed.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -15;

    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //If we are out of bounds to the left and this game object is an obstacle, destroy this game object.
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
