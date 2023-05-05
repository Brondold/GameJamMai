using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaisseSelection : MonoBehaviour
{
    public GameObject caisse_atelier_1;
    public GameObject caisse_atelier_2;
    public GameObject caisse_atelier_3;
    public GameObject caisse_atelier_4;

    public GameObject caisse_grenier_1;
    public GameObject caisse_grenier_2;
    public GameObject caisse_grenier_3;
    public GameObject caisse_grenier_4;

    private void OnMouseDown()
    {
        if(gameObject == caisse_grenier_1 && caisse_grenier_2.activeInHierarchy && caisse_grenier_3.activeInHierarchy && caisse_grenier_4.activeInHierarchy)
        {
            gameObject.SetActive(false);
            caisse_atelier_1.SetActive(true);

        }
        if(gameObject == caisse_grenier_2 && caisse_grenier_1.activeInHierarchy && caisse_grenier_3.activeInHierarchy && caisse_grenier_4.activeInHierarchy)
        {
            gameObject.SetActive(false);
            caisse_atelier_2.SetActive(true);
        }
        if(gameObject == caisse_grenier_3 && caisse_grenier_1.activeInHierarchy && caisse_grenier_2.activeInHierarchy && caisse_grenier_4.activeInHierarchy)
        {
            gameObject.SetActive(false);
            caisse_atelier_3.SetActive(true);
        }
        if (gameObject == caisse_grenier_4 && caisse_grenier_1.activeInHierarchy && caisse_grenier_2.activeInHierarchy && caisse_grenier_3.activeInHierarchy)
        {
            gameObject.SetActive(false);
            caisse_atelier_4.SetActive(true);
        }
    }
}
