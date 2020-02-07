using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SelectVideoAutomatically : MonoBehaviour
{
    public VideoPlayer _videoPlayer;

    //public string selectedVideo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
            _videoPlayer.url = "./Assets/Videos/" + "1.mp4";
        if (Input.GetKeyDown("2"))
            _videoPlayer.url = "./Assets/Videos/" + "2.mp4";
        if (Input.GetKeyDown("3"))
            _videoPlayer.url = "./Assets/Videos/" + "3.mp4";

        if (Input.GetKeyDown("space"))
            _videoPlayer.Play();
    }
}
