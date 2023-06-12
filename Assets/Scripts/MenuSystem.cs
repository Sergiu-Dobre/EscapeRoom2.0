using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;



public class MenuSystem : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("p1cutscenetest");
    }

    public void OpenSettings()
    {
        // code to open the settings menu goes here
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
