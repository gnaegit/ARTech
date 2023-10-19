using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTargetRepresentation : MonoBehaviour
{
    public GameObject description;
    public GameObject arrowsToFront;
    public GameObject arrowsToBack;
    public GameObject frontArea;
    public GameObject backArea;
    public MachineModel model;

    void Start()
    {
        //DeactivateDescription();
        DeactivateArrowsToBack();
        DeactivateArrowsToFront();
    }

    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
    }

    public void ActivateArrowsToFront()
    {
        arrowsToFront.SetActive(true);
    }

    public void DeactivateArrowsToFront()
    {
        arrowsToFront.SetActive(false);
    }

    public void ActivateArrowsToBack()
    {
        arrowsToBack.SetActive(true);
    }

    public void DeactivateArrowsToBack()
    {
        arrowsToBack.SetActive(false);
    }

    void ActivateDescription()
    {
        description.SetActive(true);
    }

    void DeactivateDescription()
    {
        description.SetActive(false);
    }

    public Boolean IsUserInFrontArea()
    {
        Collider[] hitcolliders = Physics.OverlapSphere(Camera.main.transform.position, 0f);
        
        foreach (Collider collider in hitcolliders) 
        {
            if(collider.gameObject == frontArea)
                return true;
        }

        return false;
    }
    public Boolean IsUserInBackArea()
    {
        Collider[] hitcolliders = Physics.OverlapSphere(Camera.main.transform.position, 0f);

        foreach (Collider collider in hitcolliders)
        {
            if (collider.gameObject == backArea)
                return true;
        }

        return false;
    }
}
