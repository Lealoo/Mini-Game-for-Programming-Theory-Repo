using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DPS.playerName = nameInputField.text;
    }
    public void CloseApp()
    {
        Application.Quit();
    }
    public void LoadGameScreen()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadHighScoresScreen()
    {
        SceneManager.LoadScene(2);
    }
}
