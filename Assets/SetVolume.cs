using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public void SetMusicLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVolT", Mathf.Log10(sliderValue) * 20);
    }
    public void SetSFXLevel(float sliderValue)
    {
        mixer.SetFloat("Dzwiek", Mathf.Log10(sliderValue) * 20);
    }
}