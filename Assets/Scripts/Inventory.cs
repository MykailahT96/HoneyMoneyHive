using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //[Serializable]
    public int currentHoney = 0;
    public Text honeyText;
    public int upgradePrice = 0;
    public Ammo ammoScript;

    void Start()
    {
        PlayerPrefs.SetInt("totalHoney", currentHoney);
    
    }

    // Update is called once per frame
    void Update()
    {
        honeyText.text = (PlayerPrefs.GetInt("totalHoney").ToString() + " kg");
    }

    public void UpgradeAmmo(Button button)
    {
        if(button.tag == "BU01")
        {
            Debug.Log("Button pressed");
            upgradePrice = 100;
            if(currentHoney >= upgradePrice)
            {
                //ammoDamage = ammoDamage + 5;
                currentHoney = currentHoney - upgradePrice;
                PlayerPrefs.SetInt("totalHoney", currentHoney);
                ammoScript.UpgradeDamage(5);
                Debug.Log("Increased ammo damage: +5");
            }
        }
    }

    public void AddHoney(int honeyAmount)
    {
        currentHoney = currentHoney + honeyAmount;
        PlayerPrefs.SetInt("totalHoney", currentHoney);
    }

    public void UpgradeFlower()
    {

    }

    public void UpgradeTower()
    {

    }
}
