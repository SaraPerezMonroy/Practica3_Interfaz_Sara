using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Store : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button Play = this.GetComponent<Button>();
            Play.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
         SceneManager.LoadScene("Assets/Menu/Store.unity");
    }
}
