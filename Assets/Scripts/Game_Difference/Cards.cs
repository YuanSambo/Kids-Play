using System.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Game_Difference
{
    public class Cards : MonoBehaviour
    {

    
        public void DestroyCards()
        {
            StartCoroutine(DestroyCardsCoroutine());
        }

        private IEnumerator DestroyCardsCoroutine()
        {
            GameManager.Instance.CorrectAnswer();
            yield return new WaitForSeconds(2f);
            Destroy(gameObject);
        }
        
       
    }
}
