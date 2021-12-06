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
        }
    }
}