using Unity.Mathematics;
using UnityEngine;

namespace Game_Size
{
    public class DollContainer : MonoBehaviour
    {
        public Sizes size;
    
        public GameObject confetti;

  
        public void PlayConfetti()
        {
            Instantiate(confetti, transform.position, quaternion.identity);
        }
    }
}
