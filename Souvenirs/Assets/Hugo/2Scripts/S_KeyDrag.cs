using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_KeyDrag : MonoBehaviour
{
    Vector3 mousePosition;
    public bool Available;
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
        return Camera.main.WorldToScreenPoint(transform.parent.position);
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
            transform.parent.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        }
    }
}
