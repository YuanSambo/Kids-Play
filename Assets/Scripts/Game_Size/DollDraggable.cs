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
public class DollDraggable : Draggable
{
    public Sizes size;
    
    private void OnTriggerEnter2D(Collider2D other)

    {
        var container = other.gameObject.GetComponent<DollContainer>();
        if (container != null)
        {
            var containerSize = container.size;
            if (size.Equals(containerSize) && MovementDestination != StartingPosition)
            {
                
                container.PlayConfetti();
                MovementDestination = other.transform.position;
                GetComponent<BoxCollider2D>().enabled = false;
                GameManager.Instance.CorrectAnswer();
            }
            else
            {
                GameManager.Instance.WrongAnswer();
                print("rawr");
                MovementDestination = StartingPosition;
            }
        }
    }
}
