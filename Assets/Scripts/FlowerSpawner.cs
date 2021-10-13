using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerSpawner : MonoBehaviour
{
    //public float spawnDelay = .3f;

    public GameObject flower;
    public Transform spawnPoint;
    //public Text flowerText;
    public GameObject flowerValueText;
    public int flowerValue = 0;
    
    //float nextTimeToSpawn = 0f;

    void Start()
    {

        SpawnFlower();
        SpawnText();

    }

    void SpawnFlower()
    {
        //int randomIndex = Random.Range(0,spawnPoints.Length);
        //Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(flower, spawnPoint.position, spawnPoint.rotation);
    }
    
    void SpawnText()
    {
        GameObject tempTextBox = (GameObject)Instantiate(flowerValueText, spawnPoint.position, spawnPoint.rotation);
        //flowerText.transform.SetParent(Canvas.transform, false);
        int randomNum = Random.Range(2,10);
        flowerValue = randomNum;
        
        TextMesh theText = tempTextBox.transform.getComponent<TextMesh>();
        theText.text = (randomNum.ToString() + " kg");
        //Instantiate(flowerText, spawnPoint.position, spawnPoint.rotation);
        //flowerText.text = (randomNum.ToString() + " kg");
        
        Debug.Log("Spawn text");

    }
}
/*

//Insert the empty game object with the TExtMesh attached
public GameObject distanceText;

//instantiates the object
GameObject tempTextBox = (GameObject)Instantiate(distanceText,pos,rot);

//grabs the textMesh component from the game object
TextMesh theText = tempTextBox.transform.getComponent<TextMesh>();

//sets the text
theText.text = "The Text";

*/