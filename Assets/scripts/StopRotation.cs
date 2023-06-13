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
    
    public void CambiarRotacionesAlSol()
    {
        foreach (var rotacion in rotacionesDeLosPlanetas)
        {
            rotacion.ResetRotationToSun();
            rotacion.enabled = !rotacion.enabled;
        }
    }
}
