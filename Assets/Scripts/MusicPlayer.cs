using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public List<AudioClip> musicClips = new List<AudioClip>();

    private AudioSource musicSource;

    AudioClip currentSong;


    // Start is called before the first frame update
    void Start()
    {
        currentSong = musicClips[1];
        musicSource = GetComponent<AudioSource>();
        PlayClip(currentSong);
    }

    public void PlayClip(AudioClip music)
    {
        musicSource.Stop();
        musicSource.clip = music;
        musicSource.Play();
    }

    public void ChooseSong0()
    {
            currentSong = musicClips[0];
            PlayClip(currentSong);
    }

    public void ChooseSong1()
    {
        currentSong = musicClips[1];
        PlayClip(currentSong);
    }

    public void ChooseSong2()
    {
        currentSong = musicClips[2];
        PlayClip(currentSong);
    }

    public void ChooseSong3()
    {
        currentSong = musicClips[3];
        PlayClip(currentSong);
    }

    public void ChooseSong4()
    {
        currentSong = musicClips[4];
        PlayClip(currentSong);
    }
     

}


