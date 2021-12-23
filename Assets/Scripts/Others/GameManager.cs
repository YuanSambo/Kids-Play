using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Events;

public  class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int rounds = 3;
    public string playerPrefCorrect;
    public string playerPrefWrong;
    private int _gameScore;

    private int _roundCorrect;
    private int _allCorrect;
    private int _wrongAnswer;


    private void Awake()
    {
        _allCorrect = PlayerPrefs.GetInt(playerPrefCorrect);
        _wrongAnswer = PlayerPrefs.GetInt(playerPrefWrong);
        
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
    protected void Update()
    {
        if (_roundCorrect >= rounds)
        {
            RoundWin();
            _gameScore++;
        }
        
    }
    [SerializeField] private UnityEvent onCorrectAnswer;

    public void CorrectAnswer()
    {
        _roundCorrect++;
        PlayerPrefs.SetInt(playerPrefCorrect, ++_allCorrect);
        SoundManager.Instance.Play("Sparkle");
        onCorrectAnswer?.Invoke();
    }

   

   
    [SerializeField] private UnityEvent onWrongAnswer;
    public void WrongAnswer()
    {
        PlayerPrefs.SetInt(playerPrefWrong, ++_wrongAnswer);
        onWrongAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onRoundWin;

    private void RoundWin()
    {
        onRoundWin?.Invoke();
        SoundManager.Instance.PlayWithDelay("GreatJob",0.5f);
        Reset();
    }

    private void Reset()
    {
        _roundCorrect = 0;
    }
}