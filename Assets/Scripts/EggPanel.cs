using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = System.Random;

public class EggPanel : MonoBehaviour
{
    public List<GameObject> Eggs;
    public void GenerateRandomEggs()
    {       
        DestroyEggs();
        
        var correctEggPosition = (int) CountingManager.Instance.Count;
        var pos = new List<int>() {0,1,2,3,4,5,6,7,8,9};

        pos.Remove(correctEggPosition);
        pos.Shuffle(5);

        var tempEgg = new[] { correctEggPosition, pos[0], pos[1] };
        tempEgg.Shuffle(5);

       
        for (int i = 0; i < 3; i++)
        {
             Instantiate(Eggs[tempEgg[i]], Eggs[tempEgg[i]].transform.position,Quaternion.identity,transform);
        }
        
    }

    private void DestroyEggs()
    {
        foreach (Transform egg in transform)
        {
           Destroy(egg.gameObject);
        }
    }

    
    private void SwapEggPlace(GameObject Egg1, GameObject Egg2)
    {
        GameObject temp = Egg1;
        Egg1 = Egg2;
        Egg2 = temp;
    }
}
