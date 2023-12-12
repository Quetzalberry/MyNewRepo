/*
* Denver Heneghan
* MoveTo
* Assignment9NavMesh
* This script sets a game object as a target, and causes the player to move towards it automatically on start. It also gets and sets the
* NavMeshAgent components.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Transform goal;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
