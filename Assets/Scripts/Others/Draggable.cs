using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    [HideInInspector] public bool IsDragging;
    [HideInInspector] public Vector3 StartingPosition;


    private float _movementTime = 3f;

    protected Vector3? MovementDestination;

    private void Start()
    {
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
            
           
            if (transform.position.Equals(MovementDestination))
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
        else
        {
            transform.position = Vector3.Lerp(transform.position, StartingPosition,
                _movementTime * Time.fixedDeltaTime);
            
        }
        
        
    }
}

