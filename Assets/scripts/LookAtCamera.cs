using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera myCamera;
    public Transform planeta;
    void Start()
    {
        myCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = planeta.position;
        transform.LookAt(myCamera.transform,Vector3.up);
        transform.Rotate(0,180,0);
    }
}
