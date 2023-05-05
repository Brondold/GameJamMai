using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextApparition : MonoBehaviour
{
    public bool jouet_1_fin = false;


    public GameObject jouet;


    public GameObject texte;


    public GameObject photo;


    private void OnMouseDown()
    {
        if(gameObject == jouet)
        {
            jouet_1_fin = true;

            if (jouet_1_fin)
            {
                photo.SetActive(true);
                texte.SetActive(true);
                StartCoroutine(Texte_1());
            }
        }
    }

    public void Text()
    {
        if (jouet_1_fin)
        {
            photo.SetActive(true);
            texte.SetActive(true);
            StartCoroutine(Texte_1());


        }
    }
    private IEnumerator Texte_1()
    {
        yield return new WaitForSeconds(5.0f);
        texte.SetActive(false);
        jouet.SetActive(false);
    }

}
