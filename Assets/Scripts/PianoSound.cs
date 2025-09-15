using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class PianoSound
{
    public string name;

    public AudioClip clip;

    [Range(0, 1)]
    public float volume;

    public float pitch = 1;

    [HideInInspector]
    public AudioSource source;
}