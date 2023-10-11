using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTargetRepresentation : MonoBehaviour
{
    public GameObject description;
    public MachineModel model;

    void Start()
    {
        DeactivateDescription();
    }

    void ActivateDescription()
    {
        description.SetActive(true);
    }

    void DeactivateDescription()
    {
        description.SetActive(false);
    }
}
