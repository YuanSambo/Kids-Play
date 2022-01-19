using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game_Size
{
    public class DollPanel : MonoBehaviour
    {
        public List<GameObject> Dolls;
        public List<GameObject> Dolls2;

        private List<GameObject> currentDolls;
        private int _counter;
        private int _roundCounter = 1;


        private void Awake()
        {
            Shuffle();
        }

        private void Shuffle()
        {
            currentDolls = _roundCounter % 2 == 0 ? Dolls : Dolls2;
            _counter = 0;
            currentDolls.Shuffle(10);
            
        }

        public void BeginningSpawn()
        {
            StartCoroutine(BeginningSpawnCoroutine());
        }
        private IEnumerator BeginningSpawnCoroutine()
        {
            yield return new WaitForSeconds(4f);
            SpawnDoll();
        }
        public void SpawnDoll()
        {
            if (_counter >= 4) return;
            Instantiate(currentDolls[_counter], transform.position, Quaternion.identity, transform);
            _counter++;
        }

    
        public void StartNewRoundDolls()
        {
            StartCoroutine(NewRoundDollsCoroutine());
        }

        private IEnumerator NewRoundDollsCoroutine()
        {
            _roundCounter++;
            yield return new WaitForSeconds(2f);
            DestroyDollsCoroutine();
            Shuffle();
            SpawnDoll();
        
        }

        private void DestroyDollsCoroutine()
        {
            foreach (Transform doll in transform)
            {
                Destroy(doll.gameObject);
            }
        }
    }
}