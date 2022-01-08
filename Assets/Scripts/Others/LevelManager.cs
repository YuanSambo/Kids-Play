using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   private void Start()
   {
      Time.timeScale = 1;
   }

   public void MainMenu()
   {
      SceneManager.LoadScene(1);
      SoundManager.Instance.PlayBackground("StartBackground");
      
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
      SoundManager.Instance.PlayBackground("MatchingColorBackground");
      SoundManager.Instance.PlayWithDelay("MatchingColorTitle",1.5f);


   }

   public void SecondGame()
   {
      SceneManager.LoadScene(3);
      SoundManager.Instance.PlayBackground("CountingEggsBackground");
      SoundManager.Instance.PlayWithDelay("CountingEggsTitle",1.5f);


   }

   public void ThirdGame()
   {
      SceneManager.LoadScene(4);
      SoundManager.Instance.PlayBackground("PopTheBalloonBackground");
      SoundManager.Instance.PlayWithDelay("PopTheBalloonsTitle",1.5f);


   }
   public void FourthGame()
   {
      SceneManager.LoadScene(5);
      SoundManager.Instance.PlayBackground("FindTheDifferenceBackground");
      SoundManager.Instance.PlayWithDelay("FindTheDifferenceTitle",1.5f);



   }

   public void FifthGame()
   {
      SceneManager.LoadScene(6);
      SoundManager.Instance.PlayBackground("ArrangingDollsBackground");
      SoundManager.Instance.PlayWithDelay("ArrangingDollsTitle",1.5f);


   }
}
