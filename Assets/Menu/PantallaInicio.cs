using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PantallaInicio : MonoBehaviour
{

    public GameObject Polyfarm_Text;
    public float rotationAmount = 15f;
    public float duration = 1.5f;

    void Start()
    {
        RotateText();
    }

    void RotateText() // Rotación inicial, hacia el lado izquierdo. Cuando termina, llama a la rotación hacia el otro sentido

    {
        LeanTween.rotateZ(Polyfarm_Text, rotationAmount, duration).setEase(LeanTweenType.easeInOutQuad).setOnComplete(RotateTextBack); 
    }

    void RotateTextBack() // Rota en el sentido contrario y luego llama a la rotación inicial
    {
        LeanTween.rotateZ(Polyfarm_Text, -rotationAmount, duration).setEase(LeanTweenType.easeInOutQuad).setOnComplete(RotateText);
    }

// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1); // Esto es para que salte a la siguiente escena
        }
    }
}
