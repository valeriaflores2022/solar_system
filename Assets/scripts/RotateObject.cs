using System;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float earthDays;
    public bool years;
    public Quaternion initialRot;
    private void Awake()
    {
        initialRot = transform.rotation;
    }

    void Update()
    {
        if (years) 
        {
            RotateYears();   
        }
        else
        {
            RotateDays();
        }   
        
    }

    public void RotateDays()
    {
        transform.Rotate(Vector3.up,Constants.earthDay*earthDays*360*Time.deltaTime);
    }

    public void RotateYears()
    {
        transform.Rotate(Vector3.up,Constants.earthDay*earthDays*360/365*Time.deltaTime);
    }

    public void ResetRotationToSun()
    {
        transform.rotation = initialRot;
    }
}
