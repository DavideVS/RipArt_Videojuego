using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEventClick : MonoBehaviour
{

    public void GameOverButton()
    {
        SceneManager.LoadScene("Menu_inicial");
    }

    public void ImageFake()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void GameWinButton()
    {
        SceneManager.LoadScene("Test_Map");
    }

    public void ImageRight()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Test_Map");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
