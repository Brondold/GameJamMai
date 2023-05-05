using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_DragBuild : MonoBehaviour
{
    Vector3 mousePosition;
    public bool Available;
    public Camera Atelier;
    void start()
    {
        Available = true;
    }

    public void EnableAvai()
    {
        Available = true;
    }

    public void DisableAvai()
    {
        Available = false;
    }
    
    public Vector3 GetMousePos()
    {
        //print("Pos");
        return Atelier.WorldToScreenPoint(transform.parent.position);
    }

    public void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        //print("Down");
    }

    public void OnMouseDrag()
    {
        if(Available == true)
        {
            transform.parent.position = Atelier.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        }
    }
}
