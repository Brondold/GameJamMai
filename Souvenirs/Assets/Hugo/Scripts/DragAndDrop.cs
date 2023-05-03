using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePosition;
    public bool Available;
    
   void Start()
   {
    Available = true;
   }
    
    public void TrueAvailable()
    {
        Available = true;
    }
    public void FalseAvailable()
    {
        Available = false;
    }
    public Vector3 GetMousePos()
    {
        //print("Pos");
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    public void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        //print("Down");
    }

    public void OnMouseDrag()
    {
        //Debug.Log("Drag");
        if(Available == true)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        }
        
    }
}
