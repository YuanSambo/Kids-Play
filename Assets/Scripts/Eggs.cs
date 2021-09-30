using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EggCount
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
    Count,
}
public class Eggs : MonoBehaviour
{
    public EggCount eggCount;

    public void CheckIfCorrect()
    {
        if (CountingManager.Instance.Count == eggCount)
        {
            print("Correct");
        }
        else
        {
            print("False");

        }
    }
}
