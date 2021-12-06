using System.Collections;
using UnityEngine;

namespace Game_Counting
{
    public class ChickPanel : MonoBehaviour
    {
        public GameObject Chick;
        public void GenerateRandomChicks()
        {
            StartCoroutine(GenerateRandomChicksCoroutine());

        }

        private IEnumerator GenerateRandomChicksCoroutine()
        {
            yield return new WaitForSeconds(3f);
            DestroyChicks();
            var count = CountingManager.Instance.Count;
            for (int i = 0; i < count; i++)
            {
                Instantiate(Chick,Chick.transform.position,Quaternion.identity,transform);
            }
        }

        private void DestroyChicks()
        {
            foreach (Transform chick in transform)
            {
                Destroy(chick.gameObject);
            }
        }
    
    }
}
