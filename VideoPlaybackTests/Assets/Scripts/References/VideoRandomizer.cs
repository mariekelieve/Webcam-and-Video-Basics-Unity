using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoRandomizer : MonoBehaviour
{

    public List<string> videoList = new List<string>();
    public static List<string> videoFileOptions = new List<string>();

    private void Start()
    {
        videoFileOptions = videoList;
    }

    public static string SelectRandomItemAndRemove()
    {
        if (videoFileOptions.Count > 0)
        {
            int randomValue = Random.Range(0, videoFileOptions.Count);
            string selectedRandomVideo = videoFileOptions[randomValue];
            videoFileOptions.RemoveAt(randomValue);

            return selectedRandomVideo;
        }

        else
            return null;
    }

       

}

