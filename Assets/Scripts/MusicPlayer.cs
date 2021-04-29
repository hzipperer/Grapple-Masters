using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public List<AudioClip> musicClips = new List<AudioClip>();

    GameObject audioObject;

    Audio audio;

    AudioClip currentSong;

    void Awake()
    {
        audioObject = GameObject.Find("Audio");
        audio = audioObject.GetComponent<Audio>();
        if (!audio.musicSource.isPlaying)
        {
            currentSong = musicClips[1];
            audio.PlayClip(currentSong);
        }
    }
   
    public void ChooseSong0()
    {
        currentSong = musicClips[0];
        audio.PlayClip(currentSong);
    }

    public void ChooseSong1()
    {
        currentSong = musicClips[1];
        audio.PlayClip(currentSong);
    }

    public void ChooseSong2()
    {
        currentSong = musicClips[2];
        audio.PlayClip(currentSong);
    }

    public void ChooseSong3()
    {
        currentSong = musicClips[3];
        audio.PlayClip(currentSong);
    }

    public void ChooseSong4()
    {
        currentSong = musicClips[4];
        audio.PlayClip(currentSong);
    }


}


