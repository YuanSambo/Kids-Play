using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game_Shapes
{
    public enum Shapes
    {
        Circle,
        Diamond,
        Heart,
        Square,
        Star,
        Triangle,
        Count,
    }
    public class ShapeManager : MonoBehaviour
    {
        public static ShapeManager Instance;
        public Shapes shape;
    
        private void Awake()
        {
        
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
        public void GenerateRandomShape()
        {
            var tempShape = Random.Range(0,(int)Shapes.Count);
            shape = (Shapes)tempShape;

            switch (shape)
            {
                case Shapes.Circle:
                    SoundManager.Instance.Play("PopCircle");
                    break;
                case Shapes.Diamond:
                    SoundManager.Instance.Play("PopDiamond");
                    break;
                case Shapes.Heart:
                    SoundManager.Instance.Play("PopHeart");
                    break;
                case Shapes.Square:
                    SoundManager.Instance.Play("PopSquare");
                    break;
                case Shapes.Triangle:
                    SoundManager.Instance.Play("PopTriangle");
                    break;
                case Shapes.Star:
                    SoundManager.Instance.Play("PopStar");
                    break;
            }
        }


        public void StartGenerate()
        {
            StartCoroutine(StartGenerateCoroutine());
        }
        private IEnumerator StartGenerateCoroutine()
        {
            yield return new WaitForSeconds(3.5f);
            GenerateRandomShape();
        }
    }
}