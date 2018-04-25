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
    public bool isMute = false;

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
        if (!audioSource.isPlaying && isMute == false)
        {
            PlayRandomSong();
        }
        if (Input.GetKeyDown(KeyCode.S) && isMute == false)
        {
            PlayRandomSong();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isMute)
            {
                audioSource.UnPause();
                isMute = false;
                print(audioSource.isPlaying);
            }
            else
            {
                isMute = true;

                audioSource.Pause();
            }

        }
        /* if (Input.GetKey(KeyCode.M) && isMute == true)
        {
            isMute = false;
            AudioListener.pause = !AudioListener.pause;
        } */
    }
}
