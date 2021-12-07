using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //[Serializable]
    public int currentHoney = 0;
    public Text honeyText, nameText, killsText;
    public int upgradePrice = 0;
    public Ammo ammoScript;
    public Flower flowerScript;
    public FlowerSpawner spawnerScript;
    public string playerName;
    public int kills = 0;
    public int bulletDamage;

    void Start()
    {
        PlayerPrefs.SetInt("totalHoney", currentHoney);
        PlayerPrefs.SetInt("totalKills", kills);

    }

    // Update is called once per frame
    void Update()
    {
        honeyText.text = (PlayerPrefs.GetInt("totalHoney").ToString() + " kg");
        //killsText.text = (PlayerPrefs.GetInt("totalKills").ToString() + " kills");
        bulletDamage = PlayerPrefs.GetInt("bulletDamage");
        //nameText.text = (PlayerPrefs.GetString("playerName"));
    }

    public void UpgradeAmmo(Button button)
    {
        if(button.tag == "BU01")
        {
            Debug.Log("Button pressed");
            upgradePrice = 100;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                ammoScript.UpgradeDamage(5);
                Debug.Log("Increased ammo damage: +5");
                button.interactable = false;
            }
        }
        else if(button.tag == "BU02")
        {
            Debug.Log("Button pressed");
            upgradePrice = 250;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                ammoScript.UpgradeDamage(5);
                Debug.Log("Increased ammo damage: +5");
                button.interactable = false;
            }
        }
        else if(button.tag == "BU03")
        {
            Debug.Log("Button pressed");
            upgradePrice = 500;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                ammoScript.UpgradeDamage(10);
                Debug.Log("Increased ammo damage: +10");
                button.interactable = false;
            }
        }
        else if(button.tag == "BU04")
        {
            Debug.Log("Button pressed");
            upgradePrice = 750;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                ammoScript.UpgradeDamage(10);
                Debug.Log("Increased ammo damage: +10");
                button.interactable = false;
            }
        }
        else if(button.tag == "BU05")
        {
            Debug.Log("Button pressed");
            upgradePrice = 1250;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                ammoScript.UpgradeDamage(15);
                Debug.Log("Increased ammo damage: +15");
                button.interactable = false;
            }
        }
    }

    public void AddHoney(int honeyAmount)
    {
        currentHoney = currentHoney + honeyAmount;
        PlayerPrefs.SetInt("totalHoney", currentHoney);
    }
    
    public void AddKill()
    {
        kills = kills + 1;
        PlayerPrefs.SetInt("totalKills", kills);
    }

    public void UpgradeFlowerValue(Button button)
    {
        if(button.tag == "FHU01")
        {
            Debug.Log("Button pressed");
            upgradePrice = 100;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                flowerScript.UpgradeValue(20);
                Debug.Log("Increased flower range: +20");
                button.interactable = false;
            }
        }
        else if(button.tag == "FHU02")
        {
            Debug.Log("Button pressed");
            upgradePrice = 250;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                flowerScript.UpgradeValue(20);
                Debug.Log("Increased flower range: +20");
                button.interactable = false;
            }
        }
        else if(button.tag == "FHU03")
        {
            Debug.Log("Button pressed");
            upgradePrice = 500;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                flowerScript.UpgradeValue(25);
                Debug.Log("Increased flower range: +25");
                button.interactable = false;
            }
        }
        else if(button.tag == "FHU04")
        {
            Debug.Log("Button pressed");
            upgradePrice = 750;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                flowerScript.UpgradeValue(25);
                Debug.Log("Increased flower range: +25");
                button.interactable = false;
            }
        }
        else if(button.tag == "FHU05")
        {
            Debug.Log("Button pressed");
            upgradePrice = 1500;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                flowerScript.UpgradeValue(50);
                Debug.Log("Increased flower range: +50");
                button.interactable = false;
            }
        }
    }

    public void UpgradeFlowerSpawnRate(Button button)
    {
        if(button.tag == "FSU01")
        {
            Debug.Log("Button pressed");
            upgradePrice = 100;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                spawnerScript.UpgradeSpawnRate(5);
                Debug.Log("Decrease flower spawn rate: -5");
                button.interactable = false;
            }
        }
        else if(button.tag == "FSU02")
        {
            Debug.Log("Button pressed");
            upgradePrice = 250;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                spawnerScript.UpgradeSpawnRate(5);
                Debug.Log("Decrease flower spawn rate: -5");
                button.interactable = false;
            }
        }
        else if(button.tag == "FSU03")
        {
            Debug.Log("Button pressed");
            upgradePrice = 500;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                spawnerScript.UpgradeSpawnRate(5);
                Debug.Log("Decrease flower spawn rate: -5");
                button.interactable = false;
            }
        }
        else if(button.tag == "FSU04")
        {
            Debug.Log("Button pressed");
            upgradePrice = 750;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                spawnerScript.UpgradeSpawnRate(5);
                Debug.Log("Decrease flower spawn rate: -5");
                button.interactable = false;
            }
        }
        else if(button.tag == "FSU05")
        {
            Debug.Log("Button pressed");
            upgradePrice = 1500;
            if(currentHoney >= upgradePrice)
            {
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                spawnerScript.UpgradeSpawnRate(5);
                Debug.Log("Decrease flower spawn rate: -5");
                button.interactable = false;
            }
        }
    }
}
