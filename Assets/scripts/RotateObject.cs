using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float velocidadDeRotacion;
    
    void Update()
    {
        transform.Rotate(Vector3.up,velocidadDeRotacion*Time.deltaTime);
    }
}
