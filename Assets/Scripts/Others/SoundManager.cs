using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    public Sound[] Sounds;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        Instance = this;

        foreach (Sound sound in Sounds)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.Clip;

            sound.Source.volume = sound.Volume;
            sound.Source.pitch = sound.Pitch;
            sound.Source.loop = sound.Loop;
        }

        
    }

    private void Start()
    {
        Instance.Play("StartBackground");
    }

    public void Play(string name)
    {
       StopAll();
       var sound = Array.Find(Sounds,sounds => sounds.Name == name);
        sound?.Source.Play();
    }
    
    public void Stop(string name)
    {
        var sound = Array.Find(Sounds,sounds => sounds.Name == name);
        sound?.Source.Stop();
    }

    public void StopAll()
    {
        foreach (var sound in Sounds)
        {
            sound.Source.Stop();
        }
    }
    
    
}