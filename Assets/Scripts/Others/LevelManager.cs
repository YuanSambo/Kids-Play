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
      SceneManager.LoadScene(8);
   }
   public void ParentsDashboard()
   {
      SceneManager.LoadScene(7);
   }
   public void FirstGame()
   {
      SceneManager.LoadScene(2);
   }

   public void SecondGame()
   {
      SceneManager.LoadScene(3);
   }

   public void ThirdGame()
   {
      SceneManager.LoadScene(4);
   }
   public void FifthGame()
   {
      SceneManager.LoadScene(5);
   }

   public void SixthGame()
   {
      SceneManager.LoadScene(6);
   }
}
