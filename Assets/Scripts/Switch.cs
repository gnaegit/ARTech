using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DirectionOfRotation:int
{
    CW=1,
    CCW=-1
}

public class Switch : MonoBehaviour
{
    public Material defaultMaterial;
    public GameObject switchKnob;
    public float offPosition;
    public float onPosition;
    public DirectionOfRotation directionOfRotationOn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActive(bool activate)
    {
        gameObject.SetActive(activate);
    }

    public void SetDefaultMaterial()
    {
        SetMaterial(defaultMaterial);
    }

    public void SetMaterial(Material newMaterial)
    {
        Renderer[] childrenRenderer = gameObject.GetComponentsInChildren<Renderer>();
        gameObject.GetComponent<Renderer>().material = newMaterial;
        foreach (Renderer rend in childrenRenderer)
        {
            rend.material = newMaterial;
        }
    }
}
