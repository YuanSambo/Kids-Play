using System;
using UnityEngine;

namespace Game_Counting
{
    public class Clouds : MonoBehaviour
    {
        public int number;
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void CheckIfCorrect()
        {
            if (CountingManager.Instance.Count == number)
            {
                _audioSource.Play();
                GameManager.Instance.CorrectAnswer();
            }
            else
            {
                _audioSource.Play();
                GameManager.Instance.WrongAnswer();


            }
        }
    }
}
