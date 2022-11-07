using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
