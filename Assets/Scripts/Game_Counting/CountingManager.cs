using UnityEngine;
using Random = UnityEngine.Random;

namespace Game_Counting
{
    public class CountingManager : MonoBehaviour
    {
        public static CountingManager Instance;
        public int Count;
    
        private void Awake()
        {
        
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
        public void GenerateRandomNumber()
        {
            var num = Random.Range(1,20);
            Count = num;
        }

    
    }
}
