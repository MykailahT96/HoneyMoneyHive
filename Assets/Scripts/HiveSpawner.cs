using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveSpawner : MonoBehaviour
{
   public GameObject bee;

   public Transform hiveLocation;

   
   public void SpawnBee()
   {
       Instantiate(bee, hiveLocation.position, hiveLocation.rotation);
   }

    void Update()
    {
        
    }
}
