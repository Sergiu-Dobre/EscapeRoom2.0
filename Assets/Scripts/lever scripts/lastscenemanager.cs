using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lastscenemanager : MonoBehaviour
{
    public string nextscene;

    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(nextscene);
    }
}
