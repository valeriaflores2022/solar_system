using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidRotation : MonoBehaviour
{
    private void Start() {
        transform.Rotate(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360));
    }
}