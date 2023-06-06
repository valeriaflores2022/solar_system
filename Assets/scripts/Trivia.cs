using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Trivia : MonoBehaviour
{
    public TriviaSO[] triviaData;
    public Color colorCorrecto;
    public Color colorIncorrecto;
    public Text textPuntajeTrivia;
    public Text textNumeroDeTrivia;
    public Text textPregunta;
    public Image imagenPregunta;
    public RespuestaTrivia[] respuestas;
    public Text textPuntajeTriviaCompletada;
    public GameObject ventanaTrivia;
    public GameObject ventanaTriviaCompletada;
    private int triviaActual;
    private int puntajeActual;
    void Start()
    {
        ResetTrivia();
        SetTrivia();
    }

    public void ResetTrivia()
    {
        imagenPregunta.gameObject.SetActive(false);
        ventanaTrivia.SetActive(true);
        ventanaTriviaCompletada.SetActive(false);
        textPuntajeTrivia.text = puntajeActual.ToString();
        textNumeroDeTrivia.text = triviaActual+"/"+triviaData.Length;
    }

    public void SetTrivia()
    {
        triviaActual++;
        textNumeroDeTrivia.text = triviaActual+"/" +triviaData.Length;
        textPregunta.text = triviaData[triviaActual - 1].pregunta;
        if (triviaData[triviaActual - 1].esConImagen)
        {
            imagenPregunta.gameObject.SetActive(true);
            imagenPregunta.sprite = triviaData[triviaActual - 1].imagen;
        }
        SetRespuestas();
    }

    public void SetRespuestas()
    {
        for (int i = 0; i < triviaData[triviaActual-1].respuestas.Length; i++)
        {
            respuestas[i].SetRespuesta(triviaData[triviaActual-1].respuestas[i]);
        }
    }

    public void CheckRespuesta(int respuestaIndex)
    {
        if (respuestaIndex == triviaData[triviaActual - 1].respuestaCorrecta)
        {
            respuestas[respuestaIndex-1].backGroundImage.color = colorCorrecto;
            puntajeActual += 10;
            textPuntajeTrivia.text = puntajeActual.ToString();
            StartCoroutine(SetearNuevaTrivia());
        }
        else
        {
            respuestas[respuestaIndex-1].backGroundImage.color = colorIncorrecto;
             StartCoroutine(SetearNuevaTrivia());
        }
    }

    IEnumerator SetearNuevaTrivia()
    {
        yield return new WaitForSeconds(1);
        if (triviaActual == triviaData.Length)
        {
            textPuntajeTriviaCompletada.text = puntajeActual.ToString();
            ventanaTriviaCompletada.SetActive(true);
            ventanaTrivia.SetActive(false);
        }
        else
        {
            SetTrivia();   
        }
    }
}
