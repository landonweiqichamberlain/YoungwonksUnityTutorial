using UnityEngine;
using System;   // for Array.Find

public class PianoAudioManager : MonoBehaviour
{
    public Sound[] sounds; // Shows up in Inspector

    void Awake()
    {
        // Loop through all sounds and add an AudioSource for each
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.playOnAwake = false; // prevents auto play
        }
    }

    // Method to play a sound by name
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Play();
        }

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Play("C3ToB4");
        }

        

        
    }
}