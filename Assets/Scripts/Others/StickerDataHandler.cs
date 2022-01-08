using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class RewardsData
{
    public List<string> lockedSticker = new List<string>()
    {
        "Chicken",
        "Elephant",
        "Bear",
        "Bunny",
        "Owl",
    };

    public List<string> unlockedSticker = new List<string>();
}

public static class StickerDataHandler
{
    public static void SaveStickerData(RewardsData rewardsData)
    {
        string saveJson = JsonUtility.ToJson(rewardsData);
        PlayerPrefs.SetString("Sticker_Data", saveJson);
        PlayerPrefs.Save();
    }

    public static RewardsData LoadStickerData(string dataName = "Sticker_Data")
    {
        if (PlayerPrefs.HasKey(dataName))
        {
            string saveJson = PlayerPrefs.GetString(dataName);
            return JsonUtility.FromJson<RewardsData>(saveJson);
        }
        else
        {
            return new RewardsData();
        }
    }

    public static void UnlockRandomSticker(RewardsData rewardsData)
    {
        if (rewardsData.lockedSticker.Count > 1)
        {
            rewardsData.lockedSticker.Shuffle(10);
        }
        var sticker = rewardsData.lockedSticker[0];

        rewardsData.unlockedSticker.Add(sticker);
        rewardsData.lockedSticker.Remove(sticker);
        
        SaveStickerData(rewardsData);
    }
}