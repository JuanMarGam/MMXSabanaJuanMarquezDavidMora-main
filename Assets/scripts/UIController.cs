using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    Button msgBtn;
    Button startBtn;
    Label msgText;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement root= GetComponent<UIDocument>().rootVisualElement;
        msgBtn = root.Q<Button>("msg-btn");
        startBtn = root.Q<Button>("start-btn");
        msgText = root.Q<Label>("msg-txt");

        msgBtn.clicked += ShowMessage;
        startBtn.clicked += StartGame;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowMessage()
    {
        msgText.text = "Juan Marquez & Jesus Mora";
        msgText.style.display = DisplayStyle.Flex;

    }

    void StartGame()
    {
        SceneManager.LoadScene("game");
    }
}
