using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioSource musicSource;

    void Awake()
    {
        musicSource = GetComponent<AudioSource>();
    }
    
    public void PlayClip(AudioClip music)
    {
        Debug.Log(music);
        musicSource.Stop();
        musicSource.clip = music;
        musicSource.Play();
    }
}
