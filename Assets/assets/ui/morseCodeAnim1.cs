using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morseCodeAnim1 : MonoBehaviour
{
    private Animation anim;

    public GameObject dot;
    public GameObject dash;

    int PlayerLives = 1;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(secondanim());
    }

    IEnumerator secondanim()
    {
        while(PlayerLives >= 1)
        {

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

        dash.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dash.SetActive(false);

        dash.SetActive(true);
        anim = gameObject.GetComponent<Animation>();
        yield return new WaitForSeconds(1);
        dash.SetActive(false);

        yield return new WaitForSeconds(2);
        }
    }
}
