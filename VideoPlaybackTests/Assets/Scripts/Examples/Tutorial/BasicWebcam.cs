using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWebcam : MonoBehaviour
{
    private WebCamTexture _webcamTexture;

    // Start is called before the first frame update
    void Start()
    {
        _webcamTexture = new WebCamTexture();
        _webcamTexture.Play();

        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = _webcamTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
