using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Park : MonoBehaviour
{
    public GameObject Manager;
    public GameObject SelfHandle;
    public Transform SelfParkPlace;

    public string TargetPark;
    public bool InArea;
    
    public void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.name == TargetPark) 
        {
            InArea = true;
            SelfHandle.GetComponent<S_DragBuild>().DisableAvai();
            transform.parent.position = SelfParkPlace.position;
            Manager.GetComponent<S_ParkingManager>().Add();
        }
   }
}
