using System.Collections;
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
            yield return new WaitForSeconds(1f);
            GameManager.Instance.CorrectAnswer();
            Destroy(gameObject);
        }
    }
}
