using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int bulletDamage;
    public int currentHoney;
    public string playerName;
    public int kills;

    public PlayerData(Inventory playerInventory)
    {
        bulletDamage = playerInventory.bulletDamage;
        currentHoney = playerInventory.currentHoney;
        playerName = playerInventory.playerName;
        kills = playerInventory.kills;
    }
}
