using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BasicVideoPlayback : MonoBehaviour
{
    public VideoPlayer _videoPlayer;
   
    //public string selectedVideo;

    // Start is called before the first frame update
    void Start()
    {
        _videoPlayer.url = "./Assets/Videos/" + "1.mp4";
        StartVideoPlayback();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown("1")) { 
            _videoPlayer.url = "./Assets/Videos/" + "1.mov";
            StartVideoPlayback();
        }
        if (Input.GetKeyDown("2")) { 
            _videoPlayer.url = "./Assets/Videos/" + "2.mov";
            StartVideoPlayback();
        }
       // if (Input.GetKeyDown("3")) { 
         //   _videoPlayer.url = "./Assets/Videos/" + "3.mp4";
           // StartVideoPlayback();
       // }
    }

    public void StartVideoPlayback()
    {
        _videoPlayer.Play();
    }
}
