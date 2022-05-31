using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController2 : MonoBehaviour
{
    Button mainBtn;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        mainBtn = root.Q<Button>("btn-mainmenu");

        mainBtn.clicked += MainMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MainMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
