using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CountingManager : MonoBehaviour
{
    public static CountingManager Instance;
    public Number Count;
    
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
    public void GenerateRandomNumber()
    {
        var num = (Number) Random.Range(0, (int)Number.Count);
        Count = num;
    }

    
}
