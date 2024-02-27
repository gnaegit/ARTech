using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducePressureStageInstruction : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = MachineTargetSingleton.Instance.machineTargetRepresentation.model.GetComponent<Animator>();
        animator.SetTrigger("reducePressureStageInstruction");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        animator.SetTrigger("reducePressureStageInstruction");
    }
}
