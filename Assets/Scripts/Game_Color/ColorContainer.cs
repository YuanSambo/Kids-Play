using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContainer : MonoBehaviour
{
   public Color color;
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
