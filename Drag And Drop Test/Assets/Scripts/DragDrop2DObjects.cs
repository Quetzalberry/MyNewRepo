//Drag and Drop for 2D Objects
//A collider must be attached to the 2D object 
//Adapted from https://www.youtube.com/watch?v=izag_ZHwOtM

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2DObjects : MonoBehaviour
{
    public bool dragging = false;
    private Vector3 offset;

    void Update()
    {
        if (dragging)
        {
            // Move object, taking into account original offset.
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        // Record the difference between the objects centre, and the clicked point on the camera plane.
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }
       
    void OnMouseUp() 
    {
        Debug.Log("OnMouseUp");
        dragging = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


}
