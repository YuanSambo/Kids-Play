using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void MainMenu()
   {
      SceneManager.LoadScene(1);
      SoundManager.Instance.Play("StartBackground");
      
   }
   
   public void MainMenuWithoutNew()
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
      SoundManager.Instance.Play("MatchingColorBackground");

   }

   public void SecondGame()
   {
      SceneManager.LoadScene(3);
      SoundManager.Instance.Play("CountingEggsBackground");

   }

   public void ThirdGame()
   {
      SceneManager.LoadScene(4);
      SoundManager.Instance.Play("PopTheBalloonBackground");

   }
   public void FourthGame()
   {
      SceneManager.LoadScene(5);
      SoundManager.Instance.Play("FindTheDifferenceBackground");

   }

   public void FifthGame()
   {
      SceneManager.LoadScene(6);
      SoundManager.Instance.Play("ArrangingDollsBackground");

   }
}
