using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera camera;
    public Transform planeta;
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = planeta.position;
        transform.LookAt(camera.transform,Vector3.up);
        transform.Rotate(0,180,0);
    }
}
