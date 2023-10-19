using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static SetupGoToBackInstruction;

public class SetupGoToFrontInstruction : MonoBehaviour
{
    [System.Serializable] public class OnUserIsInFrontArea : UnityEvent { }
    [SerializeField] OnUserIsInFrontArea onUserIsInFrontArea;

    // Start is called before the first frame update
    void Start()
    {
        MachineTargetSingleton.Instance.machineTargetRepresentation.ActivateArrowsToFront();
    }

    // Update is called once per frame
    void Update()
    {
        if (MachineTargetSingleton.Instance.machineTargetRepresentation.IsUserInFrontArea())
        {
            onUserIsInFrontArea.Invoke();
        }
    }

    void OnDestroy()
    {
        MachineTargetSingleton.Instance.machineTargetRepresentation.DeactivateArrowsToFront();
    }
}
