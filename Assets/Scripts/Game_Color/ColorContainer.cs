using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContainer : MonoBehaviour
{
   public ObjectColor objectColor;
   private ParticleSystem _particleSystem;

   private void Awake()
   {
      _particleSystem = GetComponent<ParticleSystem>();
   }

   private void Start()
   {
      LeanTween.scale(gameObject, new Vector3(0.7f, 0.7f, 3), .5f);

   }

   public void PlayConfetti()
   {
      _particleSystem.Play();
   }
}
