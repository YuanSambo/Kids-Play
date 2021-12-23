using System;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

namespace Game_Shapes
{
    public class Balloon : MonoBehaviour
    {
        public Shapes shape;
        public GameObject confetti;
        public Transform confettiSpawn;

        private Collider2D _collider;
        private void Awake()
        {
            _collider = GetComponent<Collider2D>();
        }

        private void Update()
        {
           
            if (transform.position.y > 8f)
            {    
                Destroy(gameObject);
            }
        }

        public void SpawnConfetti()
        {
            Instantiate(confetti,confettiSpawn.position , quaternion.identity);

        }
    }
}
