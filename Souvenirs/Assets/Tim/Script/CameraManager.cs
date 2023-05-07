using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Camera camera_grenier;
    public Camera camera_atelier;

    public GameObject bouton_retour;
    public GameObject bouton_album;
    public GameObject bouton_retour_photo;

    public GameObject album;

    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;

    public GameObject fleche1;
    public GameObject fleche2;

    public GameObject verif;

    public GameObject vjouet1;
    public GameObject vjouet2;
    public GameObject vjouet3;
    public GameObject vjouet4;

    public GameObject fin;

    //public CinemachineVirtualCamera currentCamera;
    private void Update()
    {
      if(vjouet1.activeSelf && vjouet2.activeSelf && vjouet3.activeSelf && vjouet4.activeSelf)
        {
            StartCoroutine(Timer());
            StartCoroutine(FinalScene());
        }  
    }
    public void RetourCamera()
    {
        camera_grenier.enabled = true;
        camera_atelier.enabled = false;

        bouton_retour.SetActive(false);
        bouton_album.SetActive(true);

        album.SetActive(false);

        fleche1.SetActive(true);
        fleche2.SetActive(true);

        verif.SetActive(true);
            

    }

    public void Album()
    {
        bouton_retour.SetActive(true);
        bouton_album.SetActive(false);

        fleche1.SetActive(false);
        fleche2.SetActive(false);

        album.SetActive(true);

    }

    public void Photo1()
    {
        photo1.SetActive(true);
        bouton_retour_photo.SetActive(true);

        bouton_retour.SetActive(false);
    }

    public void Photo2()
    {
        photo2.SetActive(true);
        bouton_retour_photo.SetActive(true);

        bouton_retour.SetActive(false);
    }

    public void Photo3()
    {
        photo3.SetActive(true);
        bouton_retour_photo.SetActive(true);

        bouton_retour.SetActive(false);
    }

    public void Photo4()
    {
        photo4.SetActive(true);
        bouton_retour_photo.SetActive(true);

        bouton_retour.SetActive(false);
    }

    public void RetourAlbum()
    {
        bouton_retour.SetActive(true);
        bouton_album.SetActive(false);

        fleche1.SetActive(false);
        fleche2.SetActive(false);

        album.SetActive(true);

        bouton_retour_photo.SetActive(false);

        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private IEnumerator FinalScene()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Fin");
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(5.0f);
        fin.SetActive(true);
    }
}
 