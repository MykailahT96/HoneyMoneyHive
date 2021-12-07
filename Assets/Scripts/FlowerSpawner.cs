using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerSpawner : MonoBehaviour
{
    //public float spawnDelay = .3f;

    public GameObject flower; //flower prefab
    public Transform[] spawnPoints; //flower spawnpoint
    public GameObject flowerValueText; //text prefab
    public Canvas canvas;
    //public GameObject flowerObj;
    public Camera camera1;
    public RectTransform canvas1;
    //public RectTransform flowerText;
    public Vector2 flowerPosition;
    public Flower flowerScript;
    public int maxFlowerValue = 50;
    public int minFlowerValue = 10;
    

    public float spawnDelay;
    float nextTimeToSpawn = 5f;

    void Start()
    {
        spawnDelay = 50f;
        PlayerPrefs.SetFloat("spawnDelay", 50f);
        Debug.Log("Current spawn rate: " + spawnDelay);
        PlayerPrefs.SetInt("flowerMin", minFlowerValue);
        PlayerPrefs.SetInt("flowerMax", maxFlowerValue);

    }

    void Update()
    {
        if(nextTimeToSpawn > 0)
        {
            nextTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnFlower();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnFlower()
    {
        
        int randomIndex = Random.Range(0,spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        flowerScript.SetTextPosition(spawnPoint.position);
        //FindObjectOfType<Flower>().SetTextPosition(spawnPoint.position);

        Instantiate(flower, spawnPoint.position, spawnPoint.rotation);

        flowerPosition = WorldToCanvasPosition(canvas1, camera1, spawnPoint.position);
        //flowerScript.SetTextPosition(spawnPoint.position);
        Debug.Log("Flower position: " + flowerPosition.x + " , " + flowerPosition.y);
        
        
    }

    public void UpgradeSpawnRate(float newDelay)
    {
        spawnDelay = spawnDelay - newDelay;
        Debug.Log("New flower spawn rate: " + spawnDelay + " secs.");
    }

    void SpawnText()
    {

        GameObject uiText = Instantiate(flowerValueText) as GameObject;
        uiText.transform.SetParent(canvas.transform, false);

    }
    private Vector2 WorldToCanvasPosition(RectTransform canvas, Camera camera, Vector3 position) 
    {
         //Vector position (percentage from 0 to 1) considering camera size.
         //For example (0,0) is lower left, middle is (0.5,0.5)
         Vector2 temp = camera.WorldToViewportPoint(position);
 
         //Calculate position considering our percentage, using our canvas size
         //So if canvas size is (1100,500), and percentage is (0.5,0.5), current value will be (550,250)
         temp.x *= canvas.sizeDelta.x;
         temp.y *= canvas.sizeDelta.y;
         
         //The result is ready, but, this result is correct if canvas recttransform pivot is 0,0 - left lower corner.
         //But in reality its middle (0.5,0.5) by default, so we remove the amount considering cavnas rectransform pivot.
         //We could multiply with constant 0.5, but we will actually read the value, so if custom rect transform is passed(with custom pivot) , 
         //returned value will still be correct.
         temp.x -= canvas.sizeDelta.x * canvas.pivot.x;
         temp.y -= canvas.sizeDelta.y * canvas.pivot.y;
 
         return temp;
     }


    
}
