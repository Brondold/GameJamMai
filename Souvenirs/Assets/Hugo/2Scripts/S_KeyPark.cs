using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_KeyPark : MonoBehaviour
{
    public GameObject Manager;
    public GameObject SelfHandle;
    public Transform SelfParkPlace;
    public Rigidbody Rigid;
    public Transform Van;
    public Transform Body;
    public Transform Place;
    public Transform Piece;

    public float rotationSpeed = 1f;
    public float targetRotation = 90f; // Rotation cible en degrés
    public float currentRotation = -90f;

    public string TargetPark;
    public bool InArea;
    
    public void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.name == TargetPark) 
        {
            InArea = true;
            SelfHandle.GetComponent<S_KeyDrag>().DisableAvai();
            transform.parent.position = SelfParkPlace.position;
            StartCoroutine(Delay());
        }
   }

   public IEnumerator Delay()
   {
        yield return new WaitForSeconds(1f);
        Manager.GetComponent<S_ParkingManager>().Add();        
        Quaternion target = Quaternion.Euler(targetRotation + currentRotation, 0f, -90f);
        transform.parent.rotation = Quaternion.Slerp(target, transform.parent.rotation, rotationSpeed * Time.deltaTime);
        StartCoroutine(Delay2());
   }

   public IEnumerator Delay2()
   {
        yield return new WaitForSeconds(0.5f);
        Piece.parent = Van;
        Body.parent = Van;
        Place.parent = Van;
        Rigid = Van.GetComponent<Rigidbody>();
        Rigid.AddForce(transform.up * -120f);
   }
}
