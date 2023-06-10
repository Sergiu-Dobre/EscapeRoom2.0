using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;


public class ControlsMenu : MonoBehaviour
{

    public void BackToPauseMenu()
    {
        SceneManager.LoadScene("Pause Menu");
    }

}
