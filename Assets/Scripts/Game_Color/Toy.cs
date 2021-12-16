using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Transactions;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Game_Color
{
    public enum ObjectColor
    {
        Blue,
        Red,
        Green,
        Yellow,
        Violet,
        Orange,
        Count,
    }

    public class Toy : Draggable
    {
        public ObjectColor objectColor;

        protected new void Start()
        {
            base.Start();
            LeanTween.scale(gameObject, new Vector3(0f, 0f, 1), 2f).setEasePunch();
        }
    
        private void OnTriggerEnter2D(Collider2D other)

        {
            var container = other.gameObject.GetComponent<ColorContainer>();
            if (container != null)
            {
                var containerColor = container.objectColor;
                if (objectColor.Equals(containerColor))
                {
                    Destroy(gameObject);
                    GameManager.Instance.CorrectAnswer();
                    container.PlayConfetti();
                }
                else
                {
                    GameManager.Instance.WrongAnswer();
                    MovementDestination = StartingPosition;
                }
            }
        }
    
    }
}