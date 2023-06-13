using System.Collections;
using UnityEngine;

public class PoolAsteroids : MonoBehaviour
{
    public GameObject asteroide;
    public int cantidadDeAsteroides;
    public Transform[] posicionesIniciales;
    public Transform asteroidesPadre;
    void Start()
    {
        StartCoroutine(SpawnAsteroides());
    }

    private IEnumerator SpawnAsteroides()
    {
        for (int i = 0; i < cantidadDeAsteroides; i++)
        {
            GameObject nuevoAsteroide = Instantiate(asteroide, transform.position, Quaternion.identity,asteroidesPadre);
            SetAsteroide(nuevoAsteroide);
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SetAsteroide(other.gameObject);
    }

    public void SetAsteroide(GameObject asteroideASetear)
    {
        Transform posicionInicial = posicionesIniciales[Random.Range(0, posicionesIniciales.Length)];
        asteroideASetear.transform.position = posicionInicial.position;
        asteroideASetear.transform.rotation = posicionInicial.rotation;
        asteroideASetear.transform.localScale = Vector3.one*Random.Range(0.5f,1f);
    }
    
}
