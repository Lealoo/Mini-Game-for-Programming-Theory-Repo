using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandlerHighScores : MonoBehaviour
{
    public void MainMenuLoad()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
