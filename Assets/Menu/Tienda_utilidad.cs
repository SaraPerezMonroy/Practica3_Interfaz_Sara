using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tienda_utilidad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button exitButton = GetComponent<Button>();
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(TaskOnClick);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }
}
