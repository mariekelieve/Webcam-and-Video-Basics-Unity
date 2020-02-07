using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SimpleVideoPlayer : MonoBehaviour {

    public VideoPlayer _videoPlayer;
    public AudioSource audioSource;
    public GameObject _screen;

    public string _videoPath;

    private bool isPlaying, isPaused;

    public static string selectedVideo;

    private void Awake()    {
        selectedVideo = VideoRandomizer.SelectRandomItemAndRemove();
    }
    // Use this for initialization
    void Start () { 

        _videoPlayer.playOnAwake = false;

        _videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        _videoPlayer.SetTargetAudioSource(0, audioSource);

        
        _videoPlayer.url = "./Videos/" + selectedVideo;
        //_videoPlayer.url = "./Videos/" + _videoPath;

        _videoPlayer.Prepare();
        _videoPlayer.loopPointReached += EndReached;

        StartCoroutine(PrepareToPlay());
        isPlaying = true;
     
    }


    private void EndReached(UnityEngine.Video.VideoPlayer vp) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Debug.Log("video is over");
    }

    private IEnumerator PrepareToPlay() {

        while (!_videoPlayer.isPrepared)
        {
            yield return null;
        }

        _videoPlayer.EnableAudioTrack(0, true);
        _videoPlayer.Play();
        isPlaying = true;

        //Adjusts screen to video ratio
        float videoRatio = (float)_videoPlayer.texture.height / (float) _videoPlayer.texture.width;
        _screen.transform.localScale = new Vector3(1, 1, videoRatio);
       // Debug.Log(_videoPlayer.texture.width + " and "  + _videoPlayer.texture.height + " the ratio is " + videoRatio);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space")) {

            if (!isPlaying) {
                Debug.Log("starting coroutine");
                StartCoroutine(PrepareToPlay());
                isPlaying = true;
            }

            else if (isPlaying) {
                if (isPaused)
                    _videoPlayer.Pause();

                else
                    _videoPlayer.Play();
            }

        }
    }


}
