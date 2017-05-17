using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource[] audio;
    int CurrentClip = 0;

    // Use this for initialization
    void Start()
    {
        audio = GetComponents<AudioSource>();
    }

    void Update()
    {
        Debug.Log(audio[CurrentClip].time + " out of " + audio[CurrentClip].clip.length);
    }

    public void PlayAudio()
    {
        audio[CurrentClip].Play();
    }

    public void PauseAudio()
    {
        audio[CurrentClip].Pause();
    }

    public void PlayFromPoint()
    {
        audio[CurrentClip].Play();
        //audio[CurrentClip].time = 2.0f;
    }
}
