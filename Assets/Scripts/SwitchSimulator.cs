using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class SwitchSimulator
{
    Switch switchObject;
    bool isPowerOnSimulationRunning = false;
    bool waitForReturn = false;
    float currentPosition;
    float positionIncrement = 1f;
    float timer = 0;

    public SwitchSimulator(Switch switchObject)
    {
        this.switchObject = switchObject;
        Debug.Log("Simulater is created");
        currentPosition = switchObject.offPosition;
    }

    // Update is called once per frame
    public void Update()
    {
        PowerOnSimulationUpdate();
        Debug.Log("Simulation is updating");
    }

    void PowerOnSimulationUpdate()
    {
        if (isPowerOnSimulationRunning) 
        {
            Debug.Log("Simulation is runnung:" + waitForReturn);
            if(!waitForReturn)
            {
                Vector3 tmp = switchObject.switchKnob.transform.eulerAngles;
                tmp.z = currentPosition;
                Debug.Log("Current Position is:" + currentPosition);
                switchObject.switchKnob.transform.rotation = Quaternion.Euler(tmp.x, tmp.y, tmp.z);
                currentPosition = currentPosition + ((int)switchObject.directionOfRotationOn * positionIncrement);
                if (switchObject.directionOfRotationOn == DirectionOfRotation.CW)
                {
                    if (currentPosition > switchObject.onPosition)
                    {
                        waitForReturn = true;
                        timer = 0;
                    }
                }
                else
                {
                    if (currentPosition < switchObject.onPosition)
                    {
                        waitForReturn = true;
                        timer = 0;
                    }
                }
            }
            else
            {
                Debug.Log("Timer is:" + timer);
                if (timer > 1)
                {
                    waitForReturn = false;
                    currentPosition = switchObject.offPosition;
                }
                else
                {
                    timer = timer + Time.deltaTime;
                }
            }

        }
    }

    public void StartPowerOnSimulation()
    {
        isPowerOnSimulationRunning = true;
    }
}
