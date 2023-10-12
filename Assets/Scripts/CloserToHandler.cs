using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CloserToMainCameraHandler : MonoBehaviour
{
    [System.Serializable] public class OnCloserTo : UnityEvent { }
    [SerializeField] OnCloserTo onCloserTo;

    public float thresholdDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = Vector3.Distance(Camera.main.transform.position, gameObject.transform.position);
        Vector3 difference = Camera.main.transform.position - gameObject.transform.position;

        double distance = Math.Sqrt(Math.Pow(difference.x, 2f) + Math.Pow(difference.z, 2f));
        Debug.Log(distance);
        if (distance < thresholdDistance)
        {
            onCloserTo.Invoke();
        }
    }
}
