using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationmanager : MonoBehaviour
{
    private Animation anime;

    public GameObject getup;
    public GameObject run;
    public GameObject lookar;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(animate());
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    IEnumerator animate()
    {
        yield return new WaitForSeconds(3.9f);
        getup.SetActive(false);
        run.SetActive(true);

        yield return new WaitForSeconds(2.6f);
        run.SetActive(false);
        lookar.SetActive(true);
    }
}
