using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Others
{
    public class SceneData
    {
        public string SceneName;
        public int Correct;
        public int Wrong;
        public int Plays = 0;
        public List<int> PlayTime = new List<int>();


        public string GetAveragePlayTime()
        {
            var sum = PlayTime.Sum();
            if (sum <= 0) return "00:00:00";
            var seconds =   sum/Plays;
            
            
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");

        }
    }

    public static class SceneDataHandler
    {
        public static void SaveSceneData(SceneData sceneData)
        {
            string saveJson = JsonUtility.ToJson(sceneData);
            PlayerPrefs.SetString(sceneData.SceneName,saveJson);
            PlayerPrefs.Save();
        }

        public static SceneData LoadSceneData(string sceneName)
        {
            if (PlayerPrefs.HasKey(sceneName))
            {
                string saveJson = PlayerPrefs.GetString(sceneName);
                return JsonUtility.FromJson<SceneData>(saveJson);
            }
            else
            {
                return new SceneData(){SceneName = sceneName};
            }
           
        }
    }
}