using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string playGameLevel;

    public void PlayGame()
    {
       // Application.LoadLevel(playGameLevel);
        SceneManager.LoadScene("Marciano", LoadSceneMode.Single);
    }

    public void Options()
    {

    }

    public void OpenAbout()
    {

        SceneManager.LoadScene("AcercaDe", LoadSceneMode.Single);
    }

    public void Back()
    {

        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void OpenInstrucciones()
    {

        SceneManager.LoadScene("Instrucciones", LoadSceneMode.Single);
    }

    public void OpenSettings()
    {

        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }
}
