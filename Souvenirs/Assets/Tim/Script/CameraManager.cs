using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Camera camera_grenier;
    public Camera camera_atelier;

    public GameObject bouton_retour;
    public GameObject bouton_album;

    public GameObject album;


    public GameObject verif;

    public CinemachineVirtualCamera currentCamera;

    public void RetourCamera()
    {
        camera_grenier.enabled = true;
        camera_atelier.enabled = false;

        bouton_retour.SetActive(false);
        bouton_album.SetActive(true);

        album.SetActive(false);

        verif.SetActive(true);
            

    }

    public void Album()
    {
        bouton_retour.SetActive(true);
        bouton_album.SetActive(false);

        album.SetActive(true);

    }
}
