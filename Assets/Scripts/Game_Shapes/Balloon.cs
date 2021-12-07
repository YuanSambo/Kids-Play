using UnityEngine;

namespace Game_Shapes
{
    public class Balloon : MonoBehaviour
    {
        private Vector3 _screenPosition;
        private Vector3 worldPosition;
        public Shapes shape;
    
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
                    if(shape.Equals(ShapeManager.Instance.shape))
                    {
                        GameManager.Instance.CorrectAnswer();
                        Destroy(hit.transform.gameObject);
                    }
                    else
                    {
                        GameManager.Instance.WrongAnswer();
                    }
                }
            }

            if (transform.position.y > 8f)
            {
                Destroy(gameObject);
            }
        
        

        }
    }
}
