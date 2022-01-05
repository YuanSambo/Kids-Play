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
        public List<float> PlayTime = new List<float>();


        public float GetAveragePlayTime()
        {
            float sum = PlayTime.Sum();
            return sum / Plays;
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