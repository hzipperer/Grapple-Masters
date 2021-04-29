using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public float volume;

    public void Update()
    {
        audioMixer.GetFloat("Volume", out volume);
        volumeSlider.value = volume;
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void Delete()
    {
        SaveSystem.DeleteSaves();
    }
}
