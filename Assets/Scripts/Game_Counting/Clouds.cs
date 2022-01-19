using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game_Counting
{
    public class Clouds : MonoBehaviour
    {
        public int number;
        private AudioSource _audioSource;
        private Clouds[] _clouds;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
           
        }

        public void CheckIfCorrect()
        {
            if (CountingManager.Instance.Count == number)
            { 
                _clouds = FindObjectsOfType<Clouds>();
                foreach (var cloud in _clouds)
                {
                    cloud.GetComponent<Button>().interactable = false;
                }
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
