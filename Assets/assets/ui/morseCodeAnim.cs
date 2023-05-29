using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morseCodeAnim : MonoBehaviour
{
    private Animation anim;

    public GameObject dot;
    public GameObject dash;
    public GameObject slash;

    int PlayerLives = 1;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        while(PlayerLives >= 1)
        {

        dot.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dot.SetActive(false);

        dot.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dot.SetActive(false);

        dot.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dot.SetActive(false);

        dash.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dash.SetActive(false);

        dash.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dash.SetActive(false);

        slash.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        slash.SetActive(false);
        
        slash.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        slash.SetActive(false);
        }
    }
}
