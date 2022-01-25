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

   
    public void CorrectButton()
    {      
        GameManager.Instance.WrongAnswer(-1,false);
        SpawnConfetti();
        DisableButtons();
    }

    private void SpawnConfetti()
    { 
        Instantiate(confetti, transform.position, quaternion.identity);

    }
    
    private void DisableButtons()
    {
        _differenceButtons = FindObjectsOfType<DifferenceButton>();
        foreach (var button in _differenceButtons)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }
}