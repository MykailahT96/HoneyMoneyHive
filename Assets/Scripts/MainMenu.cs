using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void ExitApplication()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("MainGameScene");
        PlayerData data = SaveSystem.LoadPlayer();

        //bulletDamage = data.bulletDamage;
        //currentHoney = data.currentHoney;
        //playerName = data.playerName;
    }

}
