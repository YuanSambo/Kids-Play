using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EggPanel : MonoBehaviour
{
    public List<GameObject> Eggs;

    public void GenerateRandomEggs()
    {
        DestroyEgg();
        Eggs.Shuffle(3);
        for (int i = 0; i < 3; i++)
        {
            var box = Instantiate(Eggs[i], Eggs[i].transform.position,Quaternion.identity,transform);
            
        }
        
    }

    public void DestroyEgg()
    {
        foreach (Transform egg in transform)
        {
           Destroy(egg.gameObject);
        }
    }
    
}
