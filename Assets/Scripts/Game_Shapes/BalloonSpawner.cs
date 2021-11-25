using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;

public class BalloonSpawner : MonoBehaviour
{
    public float spawnSpeed;
    public List<GameObject> balloons;
    public List<Transform> spawnPositions;
    private int ctr = 0;

    private void Start()
    {
        StartCoroutine(BalloonsCoroutine());
    }


    private IEnumerator BalloonsCoroutine()
    {
        while (true)
        {
            if (ctr >= balloons.Count) ctr = 0;
            var index = Random.Range(0, balloons.Count);
            var obj = Instantiate(balloons[index], spawnPositions[ctr].position, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = Vector2.up;
            ctr++;
            yield return new WaitForSeconds(spawnSpeed);
        }

        // ReSharper disable once IteratorNeverReturn
    }
}