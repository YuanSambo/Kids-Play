using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTitleUI : MonoBehaviour
{
    private float TitleSize = 1.3f;
    private RectTransform _rectTransform;
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        LeanTween.scale(gameObject, new Vector3(TitleSize,TitleSize, 1f), 1f).setOnComplete(Remove);
    }

    void Remove()
    {
        LeanTween.scale(gameObject, Vector3.zero,.5f).setDelay(2f).setDestroyOnComplete(true);
        
    }

    
}
