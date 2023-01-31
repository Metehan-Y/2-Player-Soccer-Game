using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private AudioSource AudioSrc;
    private float musicvolume;

    private void Start() 
    {
        musicvolume = 0.5f;
        AudioSrc = GetComponent<AudioSource>();
    }
    private void Update() 
    {
        AudioSrc.volume = musicvolume;    
    }
    public void SetVolume(float vol)
    {
        musicvolume = vol;
    }
}
