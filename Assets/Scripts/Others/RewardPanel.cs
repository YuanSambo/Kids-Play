using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;



[Serializable]
public struct Reward
{
    public string sticker;
    public GameObject stickerObject;
}
public class RewardPanel : MonoBehaviour
{
    public List<Reward> rewards;


    private void OnEnable()
    {
        SpawnSticker();
    }

    private void SpawnSticker()
    {
        var sticker = StickerDataHandler.LoadStickerData().unlockedSticker.Last();
        var reward = rewards.Find(x => x.sticker == sticker);
        var stickerObject = reward.stickerObject;
        var spawned = Instantiate(stickerObject,new Vector3(transform.position.x,transform.position.y + 0.5f,0), quaternion.identity, transform);
    }
    
    public void HidePanel()
    {
        Time.timeScale = 1;
        Destroy(FindObjectOfType<Sticker>().gameObject);
        gameObject.SetActive(false);
    }
}
