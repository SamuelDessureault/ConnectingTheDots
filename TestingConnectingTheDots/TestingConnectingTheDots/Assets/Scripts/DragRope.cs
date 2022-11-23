using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRope : MonoBehaviour
{
    private float camZCoord;

    // Start is called before the first frame update
    void Start()
    {
        camZCoord = Camera.main.WorldToScreenPoint(transform.position).z;
    }

    // Update is called once per frame
    void OnMouseUp()
    {
        transform.hasChanged = false;
    }

    void OnMouseDrag()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camZCoord);

        Vector3 newWorldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        transform.position = newWorldPosition;
    }
}
