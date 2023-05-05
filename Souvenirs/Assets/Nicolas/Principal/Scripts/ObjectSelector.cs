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
        // Lorsque le bouton gauche de la souris est cliqu�
        if (Input.GetMouseButtonDown(0))
        {
            // Cr�er un rayon � partir de la position de la souris
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Si le rayon touche un objet avec un nom sp�cifi� dans la liste
            if (Physics.Raycast(ray, out hit) && objectNames.Contains(hit.transform.name))
            {
                // Si l'objet n'est pas d�j� s�lectionn�
                if (!isSelected)
                {
                    // S�lectionner l'objet et le stocker dans la variable "selection"
                    selection = hit.transform.gameObject;

                    // Changer l'�tat de s�lection � vrai
                    isSelected = true;

                    // Positionner l'objet devant la cam�ra du joueur
                    selection.transform.position = transform.position + transform.forward * distance;

                    // Activer le canvas et passer l'objet s�lectionn� en enfant du canvas
                    canva02.SetActive(false);
                    canva.SetActive(true);
                    selection.transform.SetParent(canva.transform, true);
                }
            }
        }

        // Si l'objet est s�lectionn�
        if (isSelected)
        {
            // Permettre � l'utilisateur de tourner l'objet en maintenant le clic droit de la souris
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

        // Si l'objet n'est pas s�lectionn�
        if (!isSelected)
        {
            // D�sactiver le canvas
            canva.SetActive(false);
        }
    }

    // Fonction appel�e par le bouton de jet
    public void ThrowSelectedObject()
    {
        // Si l'objet est s�lectionn�
        if (isSelected)
        {
            // D�s�lectionner l'objet
            isSelected = false;

            // D�tacher l'objet du canvas et d�sactiver le canvas
            selection.transform.SetParent(null, true);
            canva.SetActive(false);
            canva02.SetActive(true);

            // Ajouter une force au Rigidbody de l'objet dans la direction de la cam�ra du joueur
            Rigidbody rb = selection.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
            rb.useGravity = true;

            // Joue le son de jet de l'objet
            audioSource.SetActive(true);
            audiosource.PlayOneShot(throwSound);

            // D�truire l'objet apr�s 5 secondes
            Destroy(selection, 2f);
        }
    }
}
