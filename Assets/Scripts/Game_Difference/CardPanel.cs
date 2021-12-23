using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game_Difference
{
    public class CardPanel : MonoBehaviour
    {
        public List<GameObject> cards;
        private int cardCounter = 0;

   

   
        public void NewSpawnCards()
        {
            StartCoroutine(NewCardCoroutine());
        }

        public void SpawnCards()
        {
            StartCoroutine(SpawnCardsCoroutine());
        }

        private IEnumerator NewCardCoroutine()
        {
            yield return new WaitForSeconds(2f);
            StartCoroutine(SpawnCardsCoroutine());
        }

        private IEnumerator SpawnCardsCoroutine()
        {
            yield return new WaitForSeconds(2f);
            if (cardCounter >= cards.Count)
            {
                cardCounter = 0;
            }
            Instantiate(cards[cardCounter],cards[cardCounter].transform.position, Quaternion.identity,transform);
            cardCounter++;
        }
    }
}
