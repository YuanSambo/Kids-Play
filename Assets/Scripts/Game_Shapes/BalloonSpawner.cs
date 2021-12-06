using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;

namespace Game_Shapes
{
    public class BalloonSpawner : MonoBehaviour
    {
        public float spawnSpeed;
        public List<GameObject> balloons;
        public List<Transform> spawnPositions;
        private int ctr = 0;

        private void Start()
        {
            StartCoroutine(BalloonsCoroutine());
        }


        private IEnumerator BalloonsCoroutine()
        {
            yield return new WaitForSeconds(3f);
            while (true)
            {
                if (ctr >= balloons.Count) ctr = 0;
                var obj = Instantiate(balloons[ctr], spawnPositions[ctr].position, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().velocity = Vector2.up;
                ctr++;
                yield return new WaitForSeconds(spawnSpeed);
            }

            // ReSharper disable once IteratorNeverReturn
        }
    }
}