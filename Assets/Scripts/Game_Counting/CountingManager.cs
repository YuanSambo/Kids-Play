using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CountingManager : MonoBehaviour
{
    public static CountingManager Instance;
    public int Count;
    
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
        var num = Random.Range(0,20);
        Count = num;
    }

    
}
