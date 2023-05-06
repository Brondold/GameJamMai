using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CaisseAtelierSelection : MonoBehaviour
{
    public GameObject caisse_atelier_1;
    public GameObject caisse_atelier_2;
    public GameObject caisse_atelier_3;
    public GameObject caisse_atelier_4;

    public GameObject caisse_grenier_1;
    public GameObject caisse_grenier_2;
    public GameObject caisse_grenier_3;
    public GameObject caisse_grenier_4;

    public GameObject texte;
    public GameObject fond;

    public GameObject verif;



    private void OnMouseDown()
    {
        if(!caisse_grenier_1.activeSelf && verif.activeInHierarchy)
        {
            caisse_atelier_1.SetActive(false);
            caisse_grenier_1.SetActive(true);
            texte.SetActive(false);
            fond.SetActive(false);
        }
        if (!caisse_grenier_2.activeSelf && verif.activeInHierarchy)
        {
            caisse_atelier_2.SetActive(false);
            caisse_grenier_2.SetActive(true);
            texte.SetActive(false);
            fond.SetActive(false);
        }
        if (!caisse_grenier_3.activeSelf && verif.activeInHierarchy)
        {
            caisse_atelier_3.SetActive(false);
            caisse_grenier_3.SetActive(true);
            texte.SetActive(false);
            fond.SetActive(false);
        }
        if (!caisse_grenier_4.activeSelf && verif.activeInHierarchy)
        {
            caisse_atelier_4.SetActive(false);
            caisse_grenier_4.SetActive(true);
            texte.SetActive(false);
            fond.SetActive(false);
        }
    }
}
