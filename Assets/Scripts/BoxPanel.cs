using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoxPanel : MonoBehaviour
{

    public List<GameObject> ColorBoxes;
    

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void RemoveBoxes()
    {
        StartCoroutine(RemoveCoroutine());
    }

    private void GenerateRandomBoxes()
    {
        var rand = Random.Range(0, (int) Color.Count);
        var g = Instantiate(ColorBoxes[rand], Vector3.zero, quaternion.identity);
    }

    private IEnumerator RemoveCoroutine()
    {
        _animator.SetTrigger("SlideTrigger");
        yield return new WaitForSeconds(1f);
        var boxes = GameObject.FindGameObjectsWithTag("DropValid");
        foreach (var box in boxes)
        {
            Destroy(box);
        }
        
        GenerateRandomBoxes();
    }
}
