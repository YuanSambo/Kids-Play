using UnityEngine;

namespace Game_Counting
{
    public class Clouds : MonoBehaviour
    {
        public int number;

        public void CheckIfCorrect()
        {
            if (CountingManager.Instance.Count == number)
            {
                GameManager.Instance.CorrectAnswer();
            }
            else
            {
                GameManager.Instance.WrongAnswer();


            }
        }
    }
}
