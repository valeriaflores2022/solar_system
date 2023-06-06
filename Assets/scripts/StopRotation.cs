using UnityEngine;

public class StopRotation : MonoBehaviour
{
    public RotateObject[] rotacionesDeLosPlanetas;

    public void CambiarRotaciones()
    {
        foreach (var rotacion in rotacionesDeLosPlanetas)
        {
            rotacion.enabled = !rotacion.enabled;
        }
    }
}
