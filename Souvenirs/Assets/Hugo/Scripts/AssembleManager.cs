using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssembleManager : MonoBehaviour
{
    public GameObject Piece1;
    public GameObject Piece2;
    public GameObject A_Anchor;
    public GameObject B_Anchor;
    private Assemble A_KP;
    private Assemble B_KP;
    public bool A_KeyPlaced;
    public bool B_Keyplaced;

    void Start()
    {
        A_KP = Piece1.GetComponent<Assemble>();
        A_KeyPlaced = A_KP.KeyPlaced;
        B_KP = Piece2.GetComponent<Assemble>();
        B_Keyplaced = B_KP.KeyPlaced;
    }
    //   Ca me gonfle
    void update()
    {
        Debug.Log(A_KeyPlaced);
        Debug.Log(B_Keyplaced);
    }

    public void A_Assemble()
    {
        if (A_KeyPlaced == true)
        {
            Piece1.GetComponent<DragAndDrop>().FalseAvailable();
            Piece1.transform.position = B_Anchor.transform.position;
            Piece1.transform.parent = B_Anchor.transform;
            //StartCoroutine(A_Waiter());
            
        }
    }

    IEnumerator A_Waiter()
    {
        yield return new WaitForSecondsRealtime(1);
        Piece1.GetComponent<DragAndDrop>().TrueAvailable();
    }
    public void B_Assemble()
    {
        if(B_Keyplaced == true)
        {
            Piece2.GetComponent<DragAndDrop>().FalseAvailable();
            Piece2.transform.position = A_Anchor.transform.position;
            Piece2.transform.parent = A_Anchor.transform;
        }
    }
}
