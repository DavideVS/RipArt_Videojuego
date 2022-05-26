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

    public void Sipnosis()
    {
         SceneManager.LoadScene("Sipnosis");
    }

     public void Tutorial()
    {
         SceneManager.LoadScene("Tutorial");
    }

    public void Tutorial1()
    {
         SceneManager.LoadScene("Tutorial1");
    }

    public void Tutorial2()
    {
         SceneManager.LoadScene("Tutorial2");
    }

    public void Tutorial3()
    {
         SceneManager.LoadScene("Tutorial3");
    }

    public void Mapa()
    {
         SceneManager.LoadScene("Mapa");
    }
}
