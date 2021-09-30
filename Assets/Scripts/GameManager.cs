using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Events;

public  class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int _gameScore;

    private int _roundCorrect;
    private int _allCorrect;
    private int _wrongAnswer;


    private void Awake()
    {
        _allCorrect = PlayerPrefs.GetInt("CorrectAnswers");
        _wrongAnswer = PlayerPrefs.GetInt("WrongAnswers");
        
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField] private UnityEvent onStart;

    private void Start()
    {
        onStart?.Invoke();
    }

    [SerializeField] private UnityEvent onCorrectAnswer;

    public void CorrectAnswer()
    {
        _roundCorrect++;
        PlayerPrefs.SetInt("CorrectAnswers", ++_allCorrect);
        onCorrectAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onWrongAnswer;

    protected void Update()
    {
        if (_roundCorrect >= 3)
        {
            RoundWin();
            _gameScore++;
            print(_gameScore);
        }
    }

    public void WrongAnswer()
    {
        PlayerPrefs.SetInt("WrongAnswers", ++_wrongAnswer);
        onWrongAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onRoundWin;

    private void RoundWin()
    {
        onRoundWin?.Invoke();
        Reset();
    }

    private void Reset()
    {
        _roundCorrect = 0;
    }
}