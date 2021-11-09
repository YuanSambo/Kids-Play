using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPanel : MonoBehaviour
{
   public List<GameObject> cards;
   private int cardCounter = 0;


   private void Update()
   {
       if (transform.childCount <= 0 && cardCounter<cards.Count)
       {
           Instantiate(cards[cardCounter],transform.position, Quaternion.identity,transform);
           cardCounter++;
       }
   }
}
