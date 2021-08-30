using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Color
{
    Blue,
    Red,
    Green
}
public class ColorDraggable :Draggable
{
    public Color color;
    private new void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);

        var containerColor = other.gameObject.GetComponent<ColorContainer>().color;

        
        if (color.Equals(containerColor))
        {
            GameManager.Instance.CorrectAnswer();
            _movementDestination = other.transform.position;
            Destroy(gameObject);
        }
        else
        {
            _movementDestination = StartingPosition;
        }
    }
}
