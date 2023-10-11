using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MachineLostHandler : MonoBehaviour
{
    [System.Serializable] public class OnMachineLost : UnityEvent { }
    [SerializeField] OnMachineLost onMachineLost;
    DefaultObserverEventHandler defaultObserverEventHandler;

    // Start is called before the first frame update
    void Start()
    {
        defaultObserverEventHandler = MachineTargetSingleton.Instance.GetComponent<DefaultObserverEventHandler>();
        defaultObserverEventHandler.OnTargetLost.AddListener(OnTargetLost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTargetLost()
    {
        onMachineLost.Invoke();
    }
}
