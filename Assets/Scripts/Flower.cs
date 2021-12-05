using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    public GameObject flowerValueText;//text prefab
    //public GameObject flower;
    //public Canvas canvas1;
    //public Camera camera1;
    public RectTransform flowerText;
    public int flowerHealth = 0;
    public float posX = 0f;
    public float posY = 0f;
    public int maxFlowerValue = 50;
    public int minFlowerValue = 10;
    //private Inventory inventoryScript;
    //public GameObject inventoryManager;

    [SerializeField] private Text valueText;
    


    void Start()
    {

        SetFlowerValue();
        valueText.text = (flowerHealth.ToString() + " kg");
        //inventoryScript = inventoryManager.GetComponent<Inventory>();
        
    }

    void Update()
    {

    }
    public void SetFlowerValue()
    {
        
        int randomNum = Random.Range(minFlowerValue,maxFlowerValue);
        flowerHealth = randomNum;
        flowerText.anchoredPosition = new Vector2(posX, posY);
        
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