using UnityEngine;

namespace Game_Shapes
{
    public class Balloon : MonoBehaviour
    {
       
        public Shapes shape;
    
        private void Update()
        {
           
            if (transform.position.y > 8f)
            {
                Destroy(gameObject);
            }
        
        

        }
    }
}
