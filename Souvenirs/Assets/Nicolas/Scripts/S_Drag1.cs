using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Drag1 : MonoBehaviour
{
    private Vector3 lastPos, currPos;
    private float rotationSpeed = -0.2f;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currPos = Input.mousePosition;
            Vector3 offset = currPos - lastPos;
            transform.RotateAround(transform.position, Vector3.up, offset.x * rotationSpeed);
        }
        lastPos = Input.mousePosition;
    }
}
