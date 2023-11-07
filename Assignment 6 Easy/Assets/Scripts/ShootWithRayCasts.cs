/*
* Denver Heneghan
* ShootWithRayCasts
* 3D Game Prototype
* If the player clicks their mouse button, the void Shoot is called. The first thing that shoot does is play the muzzle flash particle effect.
* Then the script uses RayCastHit to see if an object was actually hit. The 100 range allows for an object to be clicked and checked as long
* as it is within 100f of where the player is. If something was hit, this script checks if that object has the target script attached.
* If the object does have the target script attached, the void TakeDamage is called from the target script, and is executed. The damage is set 
* to 10, so 10 will be taken away from the float health in the Target script by the TakeDamage void. If the object that is being clicked has 
* rigidbody attached to it, then a force is applied to the object with a hitForce of 10. This moves the object forward and away from the 
* direction the player is shooting from. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRayCasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //At the beginning of the Shoot() method, play the particle effect.
        muzzleFlash.Play();

        RaycastHit hitInfo;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            //Get th Target Script off the hit object.
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();

            //If a target script was found, make the target take damage.
            if (target != null)
            {
                target.TakeDamage(damage);

                //If the shot hits a rigidbody, apply a force.
                if (hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                }
            }
        }
    }
}
