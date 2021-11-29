using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CloudPanel : MonoBehaviour
{
    public List<GameObject> Numbers;
    
   

    public void SpawnClouds()
    {
        DestroyClouds();
        var correctNumberPosition = (int) CountingManager.Instance.Count;
        var pos = new List<int>() {0,1,2,3,4,5,6,7,8,9};

        pos.Remove(correctNumberPosition);
        pos.Shuffle(5);

        var tempNumbers = new[] { correctNumberPosition, pos[0], pos[1] };
        tempNumbers.Shuffle(5);

        for (int i = 0; i < 3; i++)
        {
            Instantiate(Numbers[tempNumbers[i]], Numbers[tempNumbers[i]].transform.position,Quaternion.identity,transform);
        }
    }
    
    private void DestroyClouds()
    {
        foreach (Transform number in transform)
        {
            Destroy(number.gameObject);
        }
    }
    
}
