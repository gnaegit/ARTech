using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOnSceneSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MachineModel model = MachineTargetSingleton.Instance.machineTargetRepresentation.model;
        model.ActivateSwitch();
        model.HighlightSwitch();
    }

    // Update is called once per frame
    void Update()
    {
        MachineModel model = MachineTargetSingleton.Instance.machineTargetRepresentation.model;
    }
}
