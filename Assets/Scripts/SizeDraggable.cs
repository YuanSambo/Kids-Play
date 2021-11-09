using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Sizes
{
    First,
    Second,
    Third,
    Fourth,
    Count,
}
public class SizeDraggable : Draggable
{
    public Sizes size;
    
    private void OnTriggerEnter2D(Collider2D other)

    {
        var container = other.gameObject.GetComponent<SizeContainer>();
        if (container != null)
        {
            var containerSize = container.size;
            if (size.Equals(containerSize) && MovementDestination != StartingPosition)
            {
                GameManager.Instance.CorrectAnswer();
                MovementDestination = other.transform.position;
                GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                GameManager.Instance.WrongAnswer();
                MovementDestination = StartingPosition;
            }
        }
    }
}
