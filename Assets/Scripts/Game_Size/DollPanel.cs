using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DollPanel : MonoBehaviour
{
    public List<GameObject> Dolls;
    private int counter = 0;


    private void Awake()
    {
        Shuffle();
    }

    private void Shuffle()
    {
        counter = 0;
        Dolls.Shuffle(10);

    }

    public void BeginningSpawn()
    {
        StartCoroutine(BeginningSpawnCoroutine());
    }
    private IEnumerator BeginningSpawnCoroutine()
    {
        yield return new WaitForSeconds(3f);
        SpawnDoll();
    }
    public void SpawnDoll()
    {
        if (counter >= 4) return;
        Instantiate(Dolls[counter], transform.position, Quaternion.identity, transform);
        counter++;
    }

    
    public void StartNewRoundDolls()
    {
        StartCoroutine(NewRoundDollsCoroutine());
    }

    private IEnumerator NewRoundDollsCoroutine()
    {
        yield return new WaitForSeconds(2f);
        DestroyDollsCoroutine();
        Shuffle();
        SpawnDoll();
        
    }

    private void DestroyDollsCoroutine()
    {
        foreach (Transform doll in transform)
        {
            Destroy(doll.gameObject);
        }
    }
}