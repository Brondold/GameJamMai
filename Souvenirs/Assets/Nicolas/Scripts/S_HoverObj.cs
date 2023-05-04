using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_HoverObj : MonoBehaviour
{
    public GameObject Inspection;
    public S_InspectionObj inspectionObj;
    public int index;

    // Update is called once per frame
    void Update()
    {
        if (Inspection.activeSelf)
            return;
        print("peut importe");
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 100f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Inspection.SetActive(true);
                inspectionObj.TurnOnInspection(index);
            }
        }
    }
}