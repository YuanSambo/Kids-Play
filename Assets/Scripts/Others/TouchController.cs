using System.Collections;
using System.Collections.Generic;
using Game_Shapes;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Vector3 _screenPosition;
    private Vector3 worldPosition;

    private void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Vector3 mousePosition = Input.GetTouch(0).position;
            _screenPosition = new Vector2(mousePosition.x, mousePosition.y);
            worldPosition = Camera.main.ScreenToWorldPoint(_screenPosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                var balloon = hit.transform.GetComponent<Balloon>();
                if (balloon.shape == ShapeManager.Instance.shape)
                {
                    balloon.SpawnConfetti();
                    GameManager.Instance.CorrectAnswer();
                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    GameManager.Instance.WrongAnswer();
                }
            }
        }

    }

}
