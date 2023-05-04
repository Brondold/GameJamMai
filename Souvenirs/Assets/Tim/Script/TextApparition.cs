using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextApparition : MonoBehaviour
{
    public bool jouet_1_fin = false;
    public bool jouet_2_fin = false;
    public bool jouet_3_fin = false;

    public GameObject jouet_1;
    public GameObject jouet_2;
    public GameObject jouet_3;

    public GameObject texte_1;
    public GameObject texte_2;
    public GameObject texte_3;

    public GameObject photo_1;

    private void OnMouseDown()
    {
        if(gameObject == jouet_1)
        {
            jouet_1_fin = true;
        }

        if (gameObject == jouet_2)
        {
            jouet_2_fin = true;

        }

        if (gameObject == jouet_3)
        {
            jouet_3_fin = true;
        }

        //texte_1.SetActive(true);
        //photo_1.SetActive(true);

        Text();
    }

    public void Text()
    {
        if(jouet_1_fin)
        {
            photo_1.SetActive(true);
            texte_1.SetActive(true);
            StartCoroutine(Texte_1());
        

        }
        if (jouet_2_fin)
        {
            photo_1.SetActive(true);
            texte_2.SetActive(true);
            StartCoroutine(Texte_2());
        }
        if (jouet_3_fin)
        {
            photo_1.SetActive(true);
            texte_3.SetActive(true);
            StartCoroutine(Texte_3());
        }

    }

    private IEnumerator Texte_1()
    {
        yield return new WaitForSeconds(5.0f);
        texte_1.SetActive(false);
        jouet_1.SetActive(false);
    }

    private IEnumerator Texte_2()
    {
        yield return new WaitForSeconds(5.0f);
        texte_2.SetActive(false);
        jouet_2.SetActive(false);
    }

    private IEnumerator Texte_3()
    {
        yield return new WaitForSeconds(5.0f);
        texte_3.SetActive(false);
        jouet_3.SetActive(false);
    }

}
