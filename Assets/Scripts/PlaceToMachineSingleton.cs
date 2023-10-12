using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceToMachineSingleton : MonoBehaviour
{
    MachineModel model;
    Vector3 defaultPosition;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = gameObject.transform.position;
        model = MachineTargetSingleton.Instance.machineTargetRepresentation.model;
        gameObject.transform.position =  model.transform.position + defaultPosition;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = model.transform.position + defaultPosition;
    }
}
