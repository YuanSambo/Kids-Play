using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = System.Random;

public class ChickPanel : MonoBehaviour
{
    public GameObject Chick;
    public void GenerateRandomChicks()
    {       
        DestroyChicks();

        var count = CountingManager.Instance.Count;
        for (int i = 0; i < count; i++)
        {
             Instantiate(Chick,Chick.transform.position,Quaternion.identity,transform);
        }
        
    }

    private void DestroyChicks()
    {
        foreach (Transform chick in transform)
        {
           Destroy(chick.gameObject);
        }
    }
    
}
