using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void MainMenu()
   {
      SceneManager.LoadScene(1);

   }

   public void StickerBoard()
   {
      SceneManager.LoadScene(5);
   }
   public void ParentsDashboard()
   {
      SceneManager.LoadScene(4);
   }
   public void FirstLevel()
   {
      SceneManager.LoadScene(2);
   }

   public void SecondLevel()
   {
      SceneManager.LoadScene(3);
   }
   public void FourthLevel()
   {
      SceneManager.LoadScene(6);
   }
}
