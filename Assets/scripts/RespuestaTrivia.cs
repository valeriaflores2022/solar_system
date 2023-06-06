using UnityEngine;
using UnityEngine.UI;

public class RespuestaTrivia : MonoBehaviour
{
    public Text textRespuesta;
    public Image backGroundImage;

    public void SetRespuesta(string respuesta)
    {
        textRespuesta.text = respuesta;
        backGroundImage.color = Color.white;
    }
}
