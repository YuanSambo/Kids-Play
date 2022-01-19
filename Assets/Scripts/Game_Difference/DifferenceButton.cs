using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class DifferenceButton : MonoBehaviour
{
    public GameObject confetti;
    private DifferenceButton[] _differenceButtons;

    private void Awake()
    {
       _differenceButtons = FindObjectsOfType<DifferenceButton>();
    }

    public void PlayConfetti()
    {
        foreach (var button in _differenceButtons)
        {
            button.GetComponent<Button>().interactable = false;
        }
        Instantiate(confetti, transform.position, quaternion.identity);
    }
}