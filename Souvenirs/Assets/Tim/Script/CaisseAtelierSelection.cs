using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaisseAtelierSelection : MonoBehaviour
{
    public GameObject caisse_atelier_1;
    public GameObject caisse_atelier_2;
    public GameObject caisse_atelier_3;

    public GameObject caisse_grenier_1;
    public GameObject caisse_grenier_2;
    public GameObject caisse_grenier_3;

    private void OnMouseDown()
    {
        if(!caisse_grenier_1.activeSelf)
        {
            caisse_atelier_1.SetActive(false);
            caisse_grenier_1.SetActive(true);
        }
        if (!caisse_grenier_2.activeSelf)
        {
            caisse_atelier_2.SetActive(false);
            caisse_grenier_2.SetActive(true);
        }
        if (!caisse_grenier_3.activeSelf)
        {
            caisse_atelier_3.SetActive(false);
            caisse_grenier_3.SetActive(true);
        }
    }
}
