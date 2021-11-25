using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParentsDashboard : MonoBehaviour
{
    public Text MatchColorCorrect;
    public Text MatchColorWrong;
    public Text CountingEggsCorrect;
    public Text CountingEggsWrong;
    public Text FindTheDifferenceCorrect;
    public Text FindTheDifferenceWrong;
    public Text SizeGameCorrect;
    public Text SizeGameWrong;


    private void Start()
    {
        MatchColorCorrect.text = PlayerPrefs.GetInt("ColorGameCorrect").ToString();
        MatchColorWrong.text = PlayerPrefs.GetInt("ColorGameWrong").ToString();
        CountingEggsCorrect.text = PlayerPrefs.GetInt("CountingEggsCorrect").ToString();
        CountingEggsWrong.text = PlayerPrefs.GetInt("CountingEggsWrong").ToString();
        FindTheDifferenceCorrect.text = PlayerPrefs.GetInt("FindTheDifferenceCorrect").ToString();
        FindTheDifferenceWrong.text = PlayerPrefs.GetInt("FindTheDifferenceWrong").ToString();
        SizeGameCorrect.text = PlayerPrefs.GetInt("SizeGameCorrect").ToString();
        SizeGameWrong.text = PlayerPrefs.GetInt("SizeGameWrong").ToString();




    }
    
}
