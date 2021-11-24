using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollContainer : MonoBehaviour
{
    public Sizes size;
    
    private ParticleSystem _particleSystem;

    private void Awake()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    public void PlayConfetti()
    {
        _particleSystem.Play();
    }
}
