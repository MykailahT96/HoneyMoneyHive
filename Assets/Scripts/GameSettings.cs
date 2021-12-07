using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public InputField nameText;
    public GameObject settingWindow;
    bool settingsWindowActive =false;
    public void SetPlayerName()
    {
        PlayerPrefs.SetString("playerName", nameText.text);
    }
    
    void SetDifficulty()
    {

    }

    public void OpenSettings()
    {
        if(settingsWindowActive == false) 
        {
            settingWindow.SetActive(true);
            settingsWindowActive = true;
        }
        else
        {
            settingWindow.SetActive(false);
            settingsWindowActive = false;
           
        }
    }
    
}
