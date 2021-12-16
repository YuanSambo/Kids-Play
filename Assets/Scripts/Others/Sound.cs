using System;
using UnityEngine;

[Serializable]
public class Sound
{
    public string Name;
    public AudioClip Clip;
    [Range(0,1f)]
    public float Volume;
    [Range(0,1f)]
    public float Pitch;
    public bool Loop;
    [HideInInspector]
    public AudioSource Source;
}