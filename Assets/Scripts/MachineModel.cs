using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineModel : MonoBehaviour
{
    public GameObject mainPart;
    public GameObject block;
    public GameObject frame;
    public Switch switchObject;
    public Material InstructionMaterial;

    // Start is called before the first frame update
    void Start()
    {
        switchObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
