using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRB;
    public float speed;
    private float forwardInput;

    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        PlayerRB.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
