using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public HiveSpawner HiveSpawnerScript;
    public static int currentGold = 300;
    public static int currentHoney = 0;
    public static int totalBees = 3;
    public static int hiveCapacity = 5;
    public Text moneyText;
    public Text honeyText;
    public Text hiveText;
    public int beePrice = 0;
    public Button buyButton;

    void Start()
    {
        //moneyText.text = ("$ " + currentGold.ToString());
       //honeyText.text = (currentHoney.ToString() + " kg");
        //hiveText.text = (totalBees.ToString() + " / " + hiveCapacity.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = ("$ " + currentGold.ToString());
        honeyText.text = (currentHoney.ToString() + " kg");
        hiveText.text = (totalBees.ToString() + " / " + hiveCapacity.ToString());
    }

    public void PurchaseBee()
    {
        if(buyButton.tag == "WoBee01")
        {
            Debug.Log("Button pressed");
            beePrice = 300;
            if(currentGold >= beePrice)
            {
                currentGold = currentGold - beePrice;
                totalBees++;
                HiveSpawnerScript.SpawnBee();
                Debug.Log("Bought bee");
            }
        }
    }
}
