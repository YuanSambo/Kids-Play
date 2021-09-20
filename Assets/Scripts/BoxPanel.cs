using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoxPanel : MonoBehaviour
{

    public List<GameObject> ColorBoxes;
    public List<Transform> Positions;
    

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
        ColorBoxes.Shuffle(5);

        for (int i = 0; i < ColorBoxes.Count; i++)
        {
            var obj =Instantiate(ColorBoxes[i], new Vector2(Positions[i].position.x, Positions[i].position.y), Quaternion.identity);
            obj.transform.SetParent(transform);
        }
    }

    private IEnumerator RemoveCoroutine()
    {
        _animator.SetTrigger("SlideUpTrigger");
        yield return new WaitForSeconds(1f);
        var boxes = GameObject.FindGameObjectsWithTag("DropValid");
        foreach (var box in boxes)
        {
            Destroy(box);
        }
        GenerateRandomBoxes();
        _animator.SetTrigger("SlideDownTrigger");
    }
}
