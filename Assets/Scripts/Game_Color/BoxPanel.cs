using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

namespace Game_Color
{
    public class BoxPanel : MonoBehaviour
    {
        [Serializable]
        public struct Pair
        {
            public GameObject box;
            public GameObject toy;
        }

        public Pair[] pairs;

        public List<Transform> BoxSpawnPositions;
        public List<Transform> ToySpawnPositions;


        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }


        private void SpawnBoxes()
        {
            StartCoroutine(SpawnBoxesCoroutine());
        }

        public void FirstRoundSpawn()
        {
            StartCoroutine(FirstRoundSpawnCoroutine());
        }
    
        private IEnumerator FirstRoundSpawnCoroutine()
        {
            yield return new WaitForSeconds(3f);
            StartCoroutine(SpawnBoxesCoroutine());

        }

        private IEnumerator SpawnBoxesCoroutine()
        {
            pairs.Shuffle(10);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(pairs[i].box, BoxSpawnPositions[i].position, Quaternion.identity, transform);
                yield return new WaitForSeconds(1f);
            }

            ToySpawnPositions.Shuffle(20);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(pairs[i].toy, ToySpawnPositions[i].position,
                    Quaternion.identity, transform);

            }
        }

        public void NewRoundBoxes()
        {
            StartCoroutine(NewRoundBoxesCoroutine());
        }

        private IEnumerator NewRoundBoxesCoroutine()
        {
            var boxes = GameObject.FindGameObjectsWithTag("DropValid");

            yield return new WaitForSeconds(2f);
            for (int i = 0; i < 3; i++)
            {
                Destroy(boxes[i]);
            }

            SpawnBoxes();
        }
    }
}