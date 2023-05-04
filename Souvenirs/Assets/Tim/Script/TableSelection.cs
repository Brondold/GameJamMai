using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class TableSelection : MonoBehaviour
{
    public CinemachineVirtualCamera currentCamera;

    public Camera camera_grenier;
    public Camera camera_atelier;

    public GameObject bouton_retour;
    public GameObject bouton_album;

    public GameObject album;

    public GameObject verif;

    void Start()
    {
        camera_grenier.enabled = true;
        camera_atelier.enabled = false;
    }

    private void OnMouseDown()
    {
        if (!album.activeInHierarchy)
        {
            camera_grenier.enabled = false;
            camera_atelier.enabled = true;

            bouton_album.SetActive(false);
            bouton_retour.SetActive(true);

            verif.SetActive(false);

        }
        
    }

    private void RetourCamera()
    {
        camera_grenier.enabled = true;
        camera_atelier.enabled = false;

        bouton_retour.SetActive(false);

        verif.SetActive(true);
    }
}
