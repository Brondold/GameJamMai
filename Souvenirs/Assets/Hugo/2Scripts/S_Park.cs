using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Park : MonoBehaviour
{
    public GameObject SelfHandle;
    public GameObject Manager;
    public Transform SelfParkPlace;

    public string TargetPark;
    public bool InArea;
    
    public void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.name == TargetPark) 
        {
            InArea = true;
            SelfHandle.GetComponent<S_DragBuild>().DisableAvai();
            Manager.GetComponent<S_ParkingManager>().Add();
            transform.parent.position = SelfParkPlace.position;
        }
   }
}
