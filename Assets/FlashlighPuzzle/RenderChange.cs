using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderChange : MonoBehaviour
{
    public Renderer customRender;
    [SerializeField] private Light Lightlight;
    // Start is called before the first frame update
    void Start()
    {
        customRender = GetComponent<Renderer>();
        customRender.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
