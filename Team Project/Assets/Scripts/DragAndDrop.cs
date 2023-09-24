using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 click;
    private Vector3 move;

    private void OnMouseDown()
    {
        move = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, click.z));
    }

    private void OnMouseDrag()
    {
        Vector3 pointOnScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, click.z);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(pointOnScreen) + move;
        transform.position = mousePosition;
    }
}
