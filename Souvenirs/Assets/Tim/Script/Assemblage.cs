using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assemblage : MonoBehaviour
{

    public GameObject jouet_1;
    public GameObject jouet_2;
    public GameObject jouet_3;

    public GameObject caisse_atelier_1;
    public GameObject caisse_atelier_2;
    public GameObject caisse_atelier_3;

    public bool jouet_1_fin = false;
    public bool jouet_2_fin = false;
    public bool jouet_3_fin = false;

    private void OnMouseDown()
    {
        if(gameObject == jouet_1)
        {

        }
    }
}
