using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutsceneTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject spawnpoint;
    public GameObject player;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger cutscene");
            videoPlayer.enabled = true;
            videoPlayer.Play();
            Invoke("HideVideo", 8.0f);
           // Time.timeScale = 0f;
        }
    }

    void HideVideo()
    {
        videoPlayer.enabled = false;
        player.transform.localPosition = spawnpoint.transform.localPosition;
    }



}