using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineModel : MonoBehaviour
{
    public GameObject mainPart;
    public GameObject block;
    public GameObject frame;
    public GameObject switchObject;
    public Material InstructionMaterial;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateSwitch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateSwitch()
    {
        switchObject.SetActive(false);
    }

    public void ActivateSwitch()
    { 
        switchObject.SetActive(true); 
    }

    public void HighlightSwitch()
    {
        switchObject.GetComponent<MeshRenderer>().material = InstructionMaterial;
    }

    public void SimulatePowerSwitchOn()
    {
        switchObject.r
    }
}
