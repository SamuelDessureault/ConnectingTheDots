using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithPivots : MonoBehaviour
{
    public GameObject startAnchor;
    public GameObject endAnchor;
    private Vector3 initialScale;

    // Start is called before the first frame update
    private void Start()
    {
        initialScale = transform.localScale;
        UpdateTransformForScale();
    }

    // Update is called once per frame
    void Update()
    {
        if(startAnchor.transform.hasChanged || endAnchor.transform.hasChanged)
        {
            UpdateTransformForScale();
        }
    }

    void UpdateTransformForScale()
    {
        float distance = Vector3.Distance(startAnchor.transform.position, endAnchor.transform.position);
        transform.localScale = new Vector3(initialScale.x, distance / 2f, initialScale.z);

        Vector3 middlePoint = (startAnchor.transform.position + endAnchor.transform.position) / 2f;
        transform.position = middlePoint;

        Vector3 rotationDirection = (endAnchor.transform.position - startAnchor.transform.position);
        transform.up = rotationDirection;
    }
}
