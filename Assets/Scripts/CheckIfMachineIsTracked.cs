using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CheckIfMachineIsTracked : MonoBehaviour
{
    [System.Serializable] public class OnMachineIsTracked : UnityEvent { }
    [SerializeField] OnMachineIsTracked onMachineIsTracked;
    protected ObserverBehaviour mObserverBehaviour;
    bool allowToInvoke = true;
    float timer = 0;
    float delay = 1;

    // Start is called before the first frame update
    void Start()
    {
        mObserverBehaviour = MachineTargetSingleton.Instance.GetComponent<ObserverBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //Debug.Log("observer state: " + mObserverBehaviour.TargetStatus.Status);
        if (mObserverBehaviour.TargetStatus.Status != Status.NO_POSE && allowToInvoke == true && timer > delay)
        {
            allowToInvoke = false;
            onMachineIsTracked.Invoke();
        }
    }
}
