using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class SoundManager : MonoBehaviour {

 public List<AudioClip> BackgroundMusic = new List<AudioClip>();

    private AudioSource audioSource;
    private int currentSong;
    public bool playRandom;

    public void Start()
    {
        PlayRandomSong();
    }

    private void PlayRandomSong()
    {
        currentSong = playRandom ?  Random.Range(0, BackgroundMusic.Count) : (currentSong++ %BackgroundMusic.Count);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = BackgroundMusic[currentSong];
        audioSource.Play();
    }

    public void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayRandomSong();
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayRandomSong();
        }
    }
}
