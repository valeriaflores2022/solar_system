using UnityEngine;
[CreateAssetMenu(fileName = "triviaSO", menuName = "ScriptableObjects/Trivia", order = 0)]
public class TriviaSO : ScriptableObject
{
        public string pregunta;
        public string[] respuestas;
        public int respuestaCorrecta;
        public bool esConImagen;
        public Sprite imagen;
}
