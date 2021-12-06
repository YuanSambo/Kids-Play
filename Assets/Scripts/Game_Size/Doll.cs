using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game_Size
{
    public enum Sizes
    {
        First,
        Second,
        Third,
        Fourth,
        Count,
    }
    public class Doll : Draggable
    {
        public Sizes size;

        protected new void Start()
        {
            base.Start();
            LeanTween.scale(gameObject, new Vector3(0.24f, 0.22f, 1), 1.5f);
        }
   
        private void OnTriggerEnter2D(Collider2D other)
        {
            var container = other.gameObject.GetComponent<DollContainer>();
            if (container != null)
            {
                var containerSize = container.size;
                if (size.Equals(containerSize) && MovementDestination != StartingPosition)
                {
                
                    container.PlayConfetti();
                    Destroy(other.gameObject);
                    MovementDestination = other.transform.position;
                    GetComponent<BoxCollider2D>().enabled = false;
                    GameManager.Instance.CorrectAnswer();
                }
                else
                {
                    GameManager.Instance.WrongAnswer();
                    print("rawr");
                    MovementDestination = StartingPosition;
                }
            }
        }
    }
}