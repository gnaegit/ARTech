using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoToBackInstruction : MonoBehaviour
{
    [System.Serializable] public class OnUserIsInBackArea : UnityEvent { }
    [SerializeField] OnUserIsInBackArea onUserIsInBackArea;

    // Start is called before the first frame update
    void Start()
    {
        MachineTargetSingleton.Instance.machineTargetRepresentation.ActivateArrowsToBack();
    }

    // Update is called once per frame
    void Update()
    {
        if(MachineTargetSingleton.Instance.machineTargetRepresentation.IsUserInBackArea())
        {
            onUserIsInBackArea.Invoke();
        }
    }

    void OnDestroy()
    {
        MachineTargetSingleton.Instance.machineTargetRepresentation.DeactivateArrowsToBack();
    }
}
