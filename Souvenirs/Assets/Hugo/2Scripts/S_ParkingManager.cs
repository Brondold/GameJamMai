using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ParkingManager : MonoBehaviour
{
    public int Puzzle;
    public int GoalPuzzle;

    public bool jouet_fin = false;

    public GameObject jouet;


    public GameObject texte;

    public GameObject fond;


    public GameObject photo;

    public void Add()
    {
        Puzzle += 1;
        if(Puzzle >=GoalPuzzle)
        {
            print("fin du puzzle");
            jouet_fin = true;

            if (jouet_fin)
            {
                photo.SetActive(true);
                texte.SetActive(true);
                StartCoroutine(Texte_1());
            }
        }
    }

    public void Text()
    {
        if (jouet_fin)
        {
            photo.SetActive(true);
            texte.SetActive(true);
            fond.SetActive(true);
            StartCoroutine(Texte_1());


        }
    }

    private IEnumerator Texte_1()
    {
        yield return new WaitForSeconds(5.0f);
        texte.SetActive(false);
        jouet.SetActive(false);
        fond.SetActive(false);
    }

}
