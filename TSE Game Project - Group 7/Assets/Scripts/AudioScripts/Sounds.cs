using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sounds
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)] //range for volume
    public float volume;
    [Range(0.1f, 3f)] //range for pitch
    public float pitch;

    public bool loop;

    [HideInInspector] //audiosource hidden in inspector
    public AudioSource source;
}
