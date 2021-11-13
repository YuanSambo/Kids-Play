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
            worldPosition = Camera.main.ScreenToWorldPoint(_screenPosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(hit.transform.gameObject);

            }



        }

    }
}
