using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;

public class BoxPanel : MonoBehaviour
{
    [Serializable]
    public struct Pair
    {
        public GameObject box;
        public GameObject toy;
    }

    public Pair[] pairs;

    public List<Transform> BoxSpawnPositions;
    public List<Transform> ToySpawnPositions;


    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    
    public void GenerateRandomBoxes()
    {
      
        pairs.Shuffle(10);
        for (int i = 0; i < 3; i++)
        {
            var box = Instantiate(pairs[i].box, BoxSpawnPositions[i].position,Quaternion.identity,transform);
            
        }
        
        ToySpawnPositions.Shuffle(10);
        for (int i = 0; i < 3; i++)
        {
            var toy = Instantiate(pairs[i].toy, ToySpawnPositions[i].position,
                Quaternion.identity);
            toy.transform.SetParent(transform);
        
            
        }
    }

    public void DestroyBoxes()
    {
        StartCoroutine(DestroyBoxesCoroutine());
    }
    private IEnumerator DestroyBoxesCoroutine()
    {
        var boxes = GameObject.FindGameObjectsWithTag("DropValid");

        for (int i = 0; i < 3; i++)
        {
            Destroy(boxes[i]);
            yield return new WaitForSeconds(0f);
        }
        
        
    }

   
}