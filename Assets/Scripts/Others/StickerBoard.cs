using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class StickerBoard : MonoBehaviour
{
    public List<GameObject> LockedStickers;
    public List<GameObject> UnlockedStickers;

    private RewardsData _rewardsData;

    private void Awake()
    {
        _rewardsData = StickerDataHandler.LoadStickerData();

        if (_rewardsData.unlockedSticker.Contains("Chicken"))
        {
            Instantiate(UnlockedStickers[0], UnlockedStickers[0].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[0], LockedStickers[0].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Elephant"))
        {
            Instantiate(UnlockedStickers[1], UnlockedStickers[1].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[1], LockedStickers[1].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Bear"))
        {
            Instantiate(UnlockedStickers[2], UnlockedStickers[2].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[2], LockedStickers[2].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Bunny"))
        {
            Instantiate(UnlockedStickers[3], UnlockedStickers[3].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[3], LockedStickers[3].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Owl"))
        {
            Instantiate(UnlockedStickers[4], UnlockedStickers[4].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[4], LockedStickers[4].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Lion"))
        {
            Instantiate(UnlockedStickers[5], UnlockedStickers[5].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[5], LockedStickers[5].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Pig"))
        {
            Instantiate(UnlockedStickers[6], UnlockedStickers[6].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[6], LockedStickers[6].transform.position, quaternion.identity, transform);
        }

        if (_rewardsData.unlockedSticker.Contains("Cat"))
        {
            Instantiate(UnlockedStickers[7], UnlockedStickers[7].transform.position, quaternion.identity, transform);
        }
        else
        {
            Instantiate(LockedStickers[7], LockedStickers[7].transform.position, quaternion.identity, transform);
        }
    }
}