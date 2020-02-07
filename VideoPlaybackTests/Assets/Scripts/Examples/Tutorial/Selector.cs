using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{

    public GameObject webcamFeed;
    public GameObject videoFeed;

    public bool showWebcam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showWebcam) { 
            webcamFeed.SetActive(true);
            videoFeed.SetActive(false);
        }
        else {
            videoFeed.SetActive(true);
            webcamFeed.SetActive(false);
        }
    }
}
