using UnityEngine;

public class DragController : MonoBehaviour
{
    public Draggable LastDragged => _lastDragged;
    
    private bool _isDragActive = false;
    private Vector2 _screenPosition;
    private Vector3 _worldPosition;
    private Draggable _lastDragged;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        Input.multiTouchEnabled = false;
    }

    private void Update()
    {
        
        // Get the screen position of the cursor / finger
        _worldPosition = GetTouchPosition();


        if (_isDragActive)
        {
            if (Input.GetMouseButtonUp(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended))
            {
                Drop();
                return;
            }
            
            Drag();
            
        }
        else
        {
            // Check if theres a draggable object
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                Draggable draggable = hit.transform.gameObject.GetComponent<Draggable>();
                if (draggable != null)
                {
                    _lastDragged = draggable;
                    InitDrag();
                }
            }
            
        }
    }

    private void InitDrag()
    {
        UpdateDragStatus(true);
    }

    private void Drag()
    {
        _lastDragged.transform.position = new Vector2(_worldPosition.x, _worldPosition.y);
    }

    private void Drop()
    {
        UpdateDragStatus(false);
    }

    private void UpdateDragStatus(bool isDragging)
    {
        _isDragActive = _lastDragged.IsDragging = isDragging;
        _lastDragged.gameObject.layer = isDragging ? Layer.Dragging : Layer.Default;
    }
    
    private Vector3 GetTouchPosition()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            _screenPosition = new Vector2(mousePosition.x, mousePosition.y);
            return _camera.ScreenToWorldPoint(_screenPosition);
        }

        if (Input.touchCount > 0)
        {
            _screenPosition = Input.GetTouch(0).position;
            return _camera.ScreenToWorldPoint(_screenPosition);
        }
        
        return new Vector3(100,100,100);
    }
}