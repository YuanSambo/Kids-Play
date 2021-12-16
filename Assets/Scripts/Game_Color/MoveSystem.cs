using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MoveSystem : MonoBehaviour
{
   public GameObject correctForm;
   private bool moving;

   private float startPosX;
   private float startPosY;

   private Vector3 resetPosition;
   private void Start()
   {
      resetPosition = transform.localPosition;
   }

   private void Update()
   {
      if (moving)
      {
         Vector3 mousePos;
         mousePos = Input.mousePosition;
         mousePos = Camera.main.ScreenToWorldPoint(mousePos);

         transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, transform.position.z);
      }
   }

   private void OnMouseDown()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Vector3 mousePos = Input.mousePosition;
         mousePos = Camera.main.ScreenToWorldPoint(mousePos);

         startPosX = mousePos.x - transform.localPosition.x;
         startPosY = mousePos.y - transform.localPosition.y;

         moving = true;
      }
   }

   private void OnMouseUp()
   {
      moving = false;

      if (Mathf.Abs(transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
          Mathf.Abs(transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
      {
         var localPosition = correctForm.transform.localPosition;
         transform.localPosition = new Vector3(localPosition.x,
            localPosition.y, localPosition.z);
      }
      else
      {
         transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
      }
   }
}
