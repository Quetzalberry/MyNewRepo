/*
* Denver Heneghan
* DestroyOutOfBoundsX
* Challenge 2
* I changed the left limit to a negative number so dogs would be able to make it to the other side of the screen before they disappeared.
* I also changed it so transform.position.x had to be less than leftLimit to trigger Destroy(gameObject). This way the dogs are not destroyed
* immediately. Finally, I changed transform.position.z to transform.position.y so the balls would be destroyed once they reached the bottom
* boundary. The bottom boundary is on the y axis, not the z axis, so the balls were not getting destroyed.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -35;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            Destroy(gameObject);
        }

    }
}
