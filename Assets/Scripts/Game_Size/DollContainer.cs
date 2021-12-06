using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DollContainer : MonoBehaviour
{
    public Sizes size;
    
    public GameObject confetti;

  
    public void PlayConfetti()
    {
        Instantiate(confetti, transform.position, quaternion.identity);
    }
}
