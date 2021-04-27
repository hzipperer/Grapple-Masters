using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public List<AudioClip> musicClips = new List<AudioClip>();

    private AudioSource musicSource;

    AudioClip currentSong;

    private float songLength;

    private Coroutine musicLoop;

    private Queue musicQueue;

    // Start is called before the first frame update
    void Start()
    {
        musicQueue = new Queue(musicClips);

        musicSource = GetComponent<AudioSource>();

        StartMusic();
    }

    public void PlayClip(AudioClip music)
    {
        musicSource.Stop();
        musicSource.clip = music;
        musicSource.Play();

    }

    public void StopClip()
    {
        if (musicLoop != null)
            StopCoroutine(musicLoop);
    }

    public void StartMusic()
    {
        musicLoop = StartCoroutine(musicQueue.LoopMusic(this, 3, PlayClip));
    }

}

public class Queue
{
    List<AudioClip> clips;

    public Queue(List<AudioClip> clips)
    {
        this.clips = clips;
    }

    public IEnumerator LoopMusic(MonoBehaviour player, float delay, System.Action<AudioClip> playFunction)
    {
        while (true)
        {
            yield return player.StartCoroutine(Run(RandomizedList(clips), delay, playFunction));
        }
    }

    public IEnumerator Run(List<AudioClip> tracks, float delay, System.Action<AudioClip> playFunction)
    {
        foreach (AudioClip clip in tracks)
        {
            playFunction(clip);

            yield return new WaitForSeconds(clip.length + delay);
        }
    }

    public List<AudioClip> RandomizedList(List<AudioClip> list)
    {
        List<AudioClip> copy = new List<AudioClip>(list);

        int n = copy.Count;

        while (n > 1)
        {
            n--;

            int k = Random.Range(0, n + 1);

            AudioClip value = copy[k];

            copy[k] = copy[n];
            copy[n] = value;
        }

        return copy;
    }
        
}
