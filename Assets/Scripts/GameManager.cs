using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject marketWindowUI;
    public GameObject pauseMenuUI;

    bool MarketWindowActive = false;

    public void OpenMarketWindow()
    {
        //if else? maybe case 
        //marketWindowUI.SetActive(true);
        //Debug.Log("Opened market.");
        if(MarketWindowActive == false) 
        {
            marketWindowUI.SetActive(true);
            Debug.Log("Opened market");
            MarketWindowActive = true;
        }
        else
        {
            marketWindowUI.SetActive(false);
            Debug.Log("Closed market");
            MarketWindowActive = false;
        }
    }
}

/* 
if(marketWindowUI.SetActive() == false)
{
    marketWindowUI.SetActive(true);
    Debug.Log("Opened market");
}
else
{
    marketWindowUI.SetActive(false);
    Debug.Log("Closed market");
}

public static bool GameIsPaused = false;

void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

*/