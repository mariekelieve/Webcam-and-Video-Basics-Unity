using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class AttentionGrabberManager : MonoBehaviour
{

    public static int currentVideo;
    public VideoPlayer _videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        string currentVideoToLoad = "./Assets/Videos/Attention/" + currentVideo.ToString() + ".mp4";
        _videoPlayer.url = currentVideoToLoad;

    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Emotions");
            currentVideo = currentVideo + 1;
        }
    }
}
