using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    
    public void DestroyCards()
    {
        GameManager.Instance.CorrectAnswer();
        Destroy(gameObject);
    }
}
