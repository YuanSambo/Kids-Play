using UnityEngine;

namespace Others
{
    public class SceneData
    {
        public string sceneName;
        public int correct;
        public int wrong;
    }

    public static class SceneDataHandler
    {
        public static void SaveSceneData(SceneData sceneData)
        {
            string saveJson = JsonUtility.ToJson(sceneData);
            PlayerPrefs.SetString(sceneData.sceneName,saveJson);
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
                return new SceneData(){sceneName = sceneName};
            }
           
        }
    }
}