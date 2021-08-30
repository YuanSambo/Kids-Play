using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int _correctAnswer = 0;
    private int _wrongAnswer = 0;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }


    [SerializeField] private UnityEvent onCorrectAnswer;

    public void CorrectAnswer()
    {
        _correctAnswer++;
        onCorrectAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onWrongAnswer;

    private void Update()
    {
        if (_correctAnswer >= 3)
        {
            Win();
        }
    }

    public void WrongAnswer()
    {
        _wrongAnswer++;
        onWrongAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onWin;

    private void Win()
    {
        onWin?.Invoke();
        Reset();
    }

    private void Reset()
    {
        _correctAnswer = 0;
        _wrongAnswer = 0;
    }
}