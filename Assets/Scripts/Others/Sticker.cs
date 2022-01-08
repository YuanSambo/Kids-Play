using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sticker : MonoBehaviour
{
    private void Start()
    {
        LeanTween.scale(gameObject, new Vector3(1.5f, 1.5f, 1), 1.5f).setIgnoreTimeScale(true);

    }
}
