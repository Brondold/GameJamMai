using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public GameObject canva;
    public GameObject canva02;
    public List<string> objectNames;
    public AudioSource audiosource;
    public AudioClip throwSound;
    public GameObject audioSource;

    private GameObject selection;
    private bool isSelected = false;
    private float throwForce = 20f;
    private float distance = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // Lorsque le bouton gauche de la souris est cliqué
        if (Input.GetMouseButtonDown(0))
        {
            // Créer un rayon à partir de la position de la souris
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Si le rayon touche un objet avec un nom spécifié dans la liste
            if (Physics.Raycast(ray, out hit) && objectNames.Contains(hit.transform.name))
            {
                // Si l'objet n'est pas déjà sélectionné
                if (!isSelected)
                {
                    // Sélectionner l'objet et le stocker dans la variable "selection"
                    selection = hit.transform.gameObject;

                    // Changer l'état de sélection à vrai
                    isSelected = true;

                    // Positionner l'objet devant la caméra du joueur
                    selection.transform.position = transform.position + transform.forward * distance;

                    // Activer le canvas et passer l'objet sélectionné en enfant du canvas
                    canva02.SetActive(false);
                    canva.SetActive(true);
                    selection.transform.SetParent(canva.transform, true);
                }
            }
        }

        // Si l'objet est sélectionné
        if (isSelected)
        {
            // Permettre à l'utilisateur de tourner l'objet en maintenant le clic droit de la souris
            if (Input.GetMouseButton(0))
            {
                float horizontalSpeed = 2.0f;
                float verticalSpeed = 2.0f;
                float h = horizontalSpeed * Input.GetAxis("Mouse X");
                float v = verticalSpeed * Input.GetAxis("Mouse Y");
                selection.transform.Rotate(Vector3.up, -h, Space.World);
                selection.transform.Rotate(Vector3.left, v, Space.World);
            }
        }

        // Si l'objet n'est pas sélectionné
        if (!isSelected)
        {
            // Désactiver le canvas
            canva.SetActive(false);
        }
    }

    // Fonction appelée par le bouton de jet
    public void ThrowSelectedObject()
    {
        // Si l'objet est sélectionné
        if (isSelected)
        {
            // Désélectionner l'objet
            isSelected = false;

            // Détacher l'objet du canvas et désactiver le canvas
            selection.transform.SetParent(null, true);
            canva.SetActive(false);
            canva02.SetActive(true);

            // Ajouter une force au Rigidbody de l'objet dans la direction de la caméra du joueur
            Rigidbody rb = selection.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
            rb.useGravity = true;

            // Joue le son de jet de l'objet
            audioSource.SetActive(true);
            audiosource.PlayOneShot(throwSound);

            // Détruire l'objet après 5 secondes
            Destroy(selection, 2f);
        }
    }
}
