using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject Polyfarm_Text;
    [SerializeField] private GameObject Play;
    [SerializeField] private GameObject Store;
    [SerializeField] private GameObject Settings;
    [SerializeField] private GameObject Exit;
    [SerializeField] private GameObject InicioGrupo;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(Polyfarm_Text.GetComponent<RectTransform>(), 120, 1.5f).setOnComplete(SubirAlpha);
    }

    private void SubirAlpha()
    {
       
        InicioGrupo.GetComponent<CanvasGroup>().blocksRaycasts = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Menu"); // Esto es para que salte a la siguiente escena
        }

    }
}
