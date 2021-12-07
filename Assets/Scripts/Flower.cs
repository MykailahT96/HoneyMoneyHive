using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    public int flowerHealth = 0;
    public int maxFlowerValue = 50;
    public int minFlowerValue = 10;
    public RectTransform flowerText;
    public float posX, posY;

    [SerializeField] private Text valueText;
    


    void Start()
    {

        SetFlowerValue();
        maxFlowerValue = PlayerPrefs.GetInt("flowerMax");
        minFlowerValue = PlayerPrefs.GetInt("flowerMin");
        //flowerPosition = WorldToCanvasPosition(flowerCanvas, camera, flower.position);
        
        //valueText.text = (flowerHealth.ToString() + " kg");
        //inventoryScript = inventoryManager.GetComponent<Inventory>();
        
    }

    void Update()
    {
        valueText.text = (flowerHealth.ToString() + " kg");

        flowerText.anchoredPosition = new Vector2(posX, posY);
    }
    public void SetFlowerValue()
    {
        
        int randomNum = Random.Range(minFlowerValue,maxFlowerValue);
        flowerHealth = randomNum;
        
        Debug.Log("Flower value: " + flowerHealth.ToString());

    }

    public void CollectNectar(int damage)
    {
        
        
        if(damage >= flowerHealth)
        {
            FindObjectOfType<Inventory>().AddHoney(flowerHealth);
            flowerHealth = 0;
            Debug.Log("Flower HP: " + flowerHealth);
            //inventoryScript.currentHoney += flowerHealth;
            Wilt();
            
        }
        else
        {
            FindObjectOfType<Inventory>().AddHoney(damage);
            flowerHealth -= damage;
            //inventoryScript.currentHoney += damage;
            Debug.Log("Flower HP: " + flowerHealth);
            
        }
        Debug.Log("Harvested nectar");
    }

    void Wilt()
    {
        Destroy(gameObject);
    }

    public void UpgradeValue(int newHealth)
    {   
        minFlowerValue = minFlowerValue + newHealth;
        maxFlowerValue = maxFlowerValue + newHealth;
        PlayerPrefs.SetInt("flowerMin", minFlowerValue);
        PlayerPrefs.SetInt("flowerMax", maxFlowerValue);
        Debug.Log("New flower value range: " + minFlowerValue + ", " + maxFlowerValue);
    }
    public void SetTextPosition(Vector2 flowerPosition)
    {
        posX = flowerPosition.x;
        posY = flowerPosition.y;
        //textPosition = new Vector2(flowerPosition.x, flowerPosition.y);
        //flowerText.anchoredPosition = new Vector2(flowerPosition.x, flowerPosition.y - 40);
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


/*

*/