using System;
using UnityEngine;
public class AsteroidMovement : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward*10*Time.deltaTime);
    }
}
