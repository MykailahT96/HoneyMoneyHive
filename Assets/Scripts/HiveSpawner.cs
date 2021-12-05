using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveSpawner : MonoBehaviour
{
   //public GameObject bee;
   public GameObject waspPrefab;
   public Transform[] enemySpawnPoints;
   public float enemySpawnTimer = 15f;
   public float spawnDelay = 15f;

   
   void Start()
   {
       
   }

   
   public void SpawnWasp()
   {
       int randomIndex = Random.Range(0,enemySpawnPoints.Length);
       Transform spawnPoint = enemySpawnPoints[randomIndex];

       Instantiate(waspPrefab,spawnPoint.position, spawnPoint.rotation);
   }

    void Update()
    {
        if(enemySpawnTimer > 0)
        {
            enemySpawnTimer -= Time.deltaTime;
        }
        else
        {
            SpawnWasp();
            enemySpawnTimer += spawnDelay;
        }
    }
}
