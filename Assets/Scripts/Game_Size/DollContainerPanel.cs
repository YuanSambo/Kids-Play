using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Game_Size
{
   public class DollContainerPanel : MonoBehaviour
   {
      public List<GameObject> DollContainers;


      public void SpawnDollContainers()
      {
         StartCoroutine(SpawnDollContainersCoroutine());
      }

      private IEnumerator SpawnDollContainersCoroutine()
      {
         yield return new WaitForSeconds(4f);
         foreach (var container in DollContainers)
         {
            Instantiate(container, container.transform.position, quaternion.identity, transform);
         }
      }
   }
}
