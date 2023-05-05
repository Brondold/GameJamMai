using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject CreditsPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("TestAssemble");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal_00");
    }

    public void Credits()
    {
        if(CreditsPanel.activeSelf)
        {
            CreditsPanel.SetActive(false);
        }
        else
        {
            CreditsPanel.SetActive(true);
        }
    }
}
