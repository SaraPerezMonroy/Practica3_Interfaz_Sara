using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class box_animation : MonoBehaviour
{
    Box hor_box;
    Box vert_box;
    Button menu_1, menu_2, menu_3, menu_4, submenu_3;

    bool status;
    float t;

    float intl_left_vert, intl_top_hor;

    // Start is called before the first frame update
    void Start()
    {
        UIDocument uid = gameObject.GetComponent<UIDocument>();
        VisualElement root = uid.rootVisualElement;
        hor_box = root.Query<Box>("horizontal_box");
        vert_box = root.Query<Box>("vertical_box");

        menu_1 = root.Query<Button>("menu_1");
        menu_2 = root.Query<Button>("menu_2");
        menu_3 = root.Query<Button>("menu_3");
        menu_4 = root.Query<Button>("menu_4");
        submenu_3 = root.Query<Button>("submenu_3");

        menu_1.clicked += () => clicked_function();
        menu_2.clicked += () => clicked_function();
        menu_3.clicked += () => clicked_function();
        menu_4.clicked += () => Exit_function();
        submenu_3.clicked += () => Back_function();

        status = false;
        t = 0;

        intl_left_vert = 0;
        intl_top_hor = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void clicked_function()
    {
        status = !status;
        t = 0;
    }

    void Back_function()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }
    void Exit_function()
    {
        SceneManager.LoadScene("Menu");

    }
}
