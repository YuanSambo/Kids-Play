using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    [HideInInspector] public bool IsDragging;
    [HideInInspector] public Vector3 StartingPosition;

    private Collider2D _collider;
    private DragController _dragController;
    private float _movementTime = 15f;
    
    protected Vector3? _movementDestination;

    private void Start()
    {
        _collider = GetComponent<Collider2D>();
        _dragController = FindObjectOfType<DragController>();
        StartingPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if (_movementDestination.HasValue)
        {
            if (IsDragging)
            {
                _movementDestination = null;
                return;
            }

            if (transform.position == _movementDestination)
            {
                gameObject.layer = Layer.Default;
                _movementDestination = null;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, _movementDestination.Value,
                    _movementTime * Time.fixedDeltaTime);
            }

            
        }else if (transform.position != StartingPosition)
        {
            transform.position = Vector3.Lerp(transform.position, StartingPosition,
                _movementTime * Time.fixedDeltaTime);
        }
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        Draggable collidedDraggable = other.GetComponent<Draggable>();

        if (collidedDraggable != null && _dragController.LastDragged.gameObject == gameObject)
        {
            ColliderDistance2D colliderDistance2D = other.Distance(_collider);
            Vector3 diff = new Vector3(colliderDistance2D.normal.x, colliderDistance2D.normal.y) *
                           colliderDistance2D.distance;
            transform.position -= diff;
        }

      
    }
}