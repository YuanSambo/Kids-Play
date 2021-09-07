using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public enum Color
{
    Blue,
    Red,
    Green,
    Yellow,
    Count,
}

public class ColorDraggable : Draggable
{
    public Color color;

    private void OnTriggerEnter2D(Collider2D other)

    {
        var container = other.gameObject.GetComponent<ColorContainer>();
        if (container != null)
        {
            var containerColor = container.color;
            if (color.Equals(containerColor))
            {
                GameManager.Instance.CorrectAnswer();
                MovementDestination = other.transform.position;
                Destroy(gameObject);
            }
            else
            {
                MovementDestination = StartingPosition;
            }
        }


       
    }
}