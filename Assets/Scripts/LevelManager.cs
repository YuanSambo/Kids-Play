using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void MainMenu()
   {
      SceneManager.LoadScene(1);

   }
   public void FirstLevel()
   {
      SceneManager.LoadScene(2);
   }
}
