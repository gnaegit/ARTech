using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOnSceneSetup : MonoBehaviour
{
    MachineModel model;
    Switch switchObject;
    SwitchSimulator switchSimulator;

    // Start is called before the first frame update
    void Start()
    {
        model = MachineTargetSingleton.Instance.machineTargetRepresentation.model;
        switchObject = model.switchObject;
        switchSimulator = new SwitchSimulator(switchObject);
        switchSimulator.StartPowerOnSimulation();

        switchObject.SetActive(true);
        switchObject.SetMaterial(model.InstructionMaterial);
    }

    // Update is called once per frame
    void Update()
    {
        switchSimulator.Update();
    }

    private void OnDestroy()
    {
        switchObject.SetDefaultMaterial();
        switchObject.SetActive(false);
    }
}
