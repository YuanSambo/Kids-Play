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

    protected Vector3? MovementDestination;

    private void Start()
    {
        _collider = GetComponent<Collider2D>();
        _dragController = FindObjectOfType<DragController>();
        StartingPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if (MovementDestination.HasValue)
        {
            if (IsDragging)
            {
                MovementDestination = null;
                return;
            }

            if (transform.position == MovementDestination)
            {
                gameObject.layer = Layer.Default;
                MovementDestination = null;
            }

            else
            {
                gameObject.layer = Layer.Dragging;
                transform.position = Vector3.Lerp(transform.position, MovementDestination.Value,
                    _movementTime * Time.fixedDeltaTime);
            }
        }
       
    }
}

