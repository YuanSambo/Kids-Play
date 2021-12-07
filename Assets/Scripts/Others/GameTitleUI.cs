using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTitleUI : MonoBehaviour
{
    // Start is called before the first frame update
    private RectTransform _rectTransform;
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        LeanTween.scale(gameObject, new Vector3(1.3f,1.3f, 1f), 1f).setOnComplete(Remove);
    }

    void Remove()
    {
        LeanTween.scale(gameObject, Vector3.zero,.5f).setDelay(2f).setDestroyOnComplete(true);
        
    }

    
}
