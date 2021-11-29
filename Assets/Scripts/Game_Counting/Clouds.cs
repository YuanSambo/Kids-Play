using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO 
public enum Number
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    // Eleven,
    // Twelve,
    // Thirteen,
    // Fourteen,
    // Fifteen,
    // Sixteen,
    // Seventeen,
    // Eighteen,
    // Nineteen,
    // Twenty,
    Count,
}
public class Clouds : MonoBehaviour
{
    public Number number;

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
