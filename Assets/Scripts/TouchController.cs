using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Vector3 _screenPosition;
    private Vector3 worldPosition;
    
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            _screenPosition = new Vector2(mousePosition.x, mousePosition.y);
        }
        else if (Input.touchCount > 0)
        {
            _screenPosition = Input.GetTouch(0).position;
            worldPosition = Camera.current.ScreenToWorldPoint(_screenPosition);
            
            
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                hit.transform.localScale = new Vector3(3, 3, 3);
            }
        }
        else
        {
            return;
        }

        
      
        
    }
}
