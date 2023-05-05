using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_AddVelocity : MonoBehaviour
{
    public GameObject objectToMove; // l'objet qui doit recevoir la velocity
    public float velocityMagnitude = 10f; // la magnitude de la velocity à ajouter
    public Button moveButton; // le bouton qui doit déclencher le mouvement

    private bool isMoving = false; // pour savoir si l'objet est en mouvement
    private Rigidbody rb;

    void Start()
    {
        rb = objectToMove.GetComponent<Rigidbody>();
        moveButton.onClick.AddListener(MoveObject);
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            Vector3 velocity = objectToMove.transform.forward * velocityMagnitude;
            rb.velocity = velocity;
        }
    }

    void MoveObject()
    {
        isMoving = true;
    }
}
