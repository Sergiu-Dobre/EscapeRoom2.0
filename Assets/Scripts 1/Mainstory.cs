using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainstory : MonoBehaviour
{
   void OnEnable()
   {
    SceneManager. LoadScene("IntroLable", LoadSceneMode. Single);
   }
}
