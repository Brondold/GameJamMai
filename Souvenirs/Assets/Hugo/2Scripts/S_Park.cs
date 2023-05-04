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
        print("Collision");
        if (other.gameObject.name == TargetPark) 
        {
            InArea = true;
            SelfHandle.GetComponent<S_Drag>().DisableAvai();
            transform.parent.position = SelfParkPlace.position;
            StartCoroutine(Delay());
        }
   }

   public IEnumerator Delay()
   {
        yield return new WaitForSeconds(.1f);
        print("tourne");
        Manager.GetComponent<S_ParkingManager>().Add();
   }
}
