using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assemble : MonoBehaviour
{
    public GameObject AManager;
    public string KeyPiece;
    public bool KeyPlaced;
    public void OnTriggerEnter (Collider other) 
    { 
        if (other.gameObject.tag == KeyPiece ) 
        {
            KeyPlaced = true;
            if ( KeyPiece == "Piece1")
            {
                AManager.GetComponent<AssembleManager>().A_Assemble();
            }
            else if ( KeyPiece == "Piece1")
            {
                AManager.GetComponent<AssembleManager>().B_Assemble();
            }
        }
   } 
}
