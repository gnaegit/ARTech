using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnInstruction : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = MachineTargetSingleton.Instance.machineTargetRepresentation.model.GetComponent<Animator>();
        animator.SetTrigger("startInstruction");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        animator.SetTrigger("startInstruction");
    }
}
