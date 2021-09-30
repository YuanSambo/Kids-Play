using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPanel : MonoBehaviour
{
    public List<GameObject> Numbers;
    
    public void DestroyNumberDisplay()
    {
        Destroy(transform.GetChild(0).gameObject);
    }

    public void UpdateNumber()
    {
        var num = (int)CountingManager.Instance.Count;
        Instantiate(Numbers[num], transform.position, Quaternion.identity, transform);

    }
    
}
