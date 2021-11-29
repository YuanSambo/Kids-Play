using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Clouds : MonoBehaviour
{
    public int number;

    public void CheckIfCorrect()
    {
        if (CountingManager.Instance.Count == number)
        {
            GameManager.Instance.CorrectAnswer();
        }
        else
        {
            print("False");

        }
    }
}
