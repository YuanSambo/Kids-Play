using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CountingManager : MonoBehaviour
{
    public static CountingManager Instance;
    public EggCount Count;
    
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
        var num = (EggCount) Random.Range(0, (int)EggCount.Count);
        Count = num;
    }

    
}
