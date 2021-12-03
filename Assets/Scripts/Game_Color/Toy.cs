using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.PlayerLoop;

public enum ObjectColor
{
    Blue,
    Red,
    Green,
    Yellow,
    Violet,
    Orange,
    Count,
}

public class Toy : Draggable
{
    public ObjectColor objectColor;

    
    private void OnTriggerEnter2D(Collider2D other)

    {
        var container = other.gameObject.GetComponent<ColorContainer>();
        if (container != null)
        {
            var containerColor = container.objectColor;
            if (objectColor.Equals(containerColor) && MovementDestination != StartingPosition)
            {
                Destroy(gameObject);
                GameManager.Instance.CorrectAnswer();
                container.PlayConfetti();
            }
            else
            {
                GameManager.Instance.WrongAnswer();
                MovementDestination = StartingPosition;
            }
        }
    }
    
}