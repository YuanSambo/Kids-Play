using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game_Counting
{
    public class CloudPanel : MonoBehaviour
    {
        public List<GameObject> Numbers;
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
    
        public void SpawnClouds()
        {
            StartCoroutine(SpawnCloudsCoroutine());
        }
        private IEnumerator SpawnCloudsCoroutine()
        {
            yield return new WaitForSeconds(3f);
            _animator.SetTrigger("CloudSpawn");
        
            var correctNumberPosition = CountingManager.Instance.Count-1;
            var pos = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};

            pos.Remove(correctNumberPosition);
            pos.Shuffle(5);

            var tempNumbers = new[] { correctNumberPosition, pos[0], pos[1] };
      
            tempNumbers.Shuffle(5);


            for (int i = 0; i < 3; i++)
            {
                Instantiate(Numbers[tempNumbers[i]], Numbers[tempNumbers[i]].transform.position,Quaternion.identity,transform);
            }
        }


        public void DestroyClouds()
        {
            StartCoroutine(DestroyCloudsCoroutine());
        }
    
        private IEnumerator DestroyCloudsCoroutine()
        {
            yield return new WaitForSeconds(1f);
            _animator.SetTrigger("CloudRemove");
            yield return new WaitForSeconds(1f);
            foreach (Transform number in transform)
            {
                Destroy(number.gameObject);
            }

        }
    
    }
}
