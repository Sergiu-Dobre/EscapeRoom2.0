using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneone : MonoBehaviour
{
    public string p2cutscenetest;
    public string playlvl; // Name of the scene you want to switch to
    public float delayTime = 900f; // Delay time in seconds

    private float timer;

    private void Start()
    {
        timer = 0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delayTime)
        {
            ChangeScene();
            Debug.Log("yez");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(playlvl);
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(p2cutscenetest);
    }
}