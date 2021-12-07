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
    public static bool GameIsPaused = false;

    void Start()
    {
        
    }
    public void OpenMarketWindow()
    {
        
        if(MarketWindowActive == false) 
        {
            marketWindowUI.SetActive(true);
            Debug.Log("Opened market");
            MarketWindowActive = true;
            Time.timeScale = 0f;
        }
        else
        {
            marketWindowUI.SetActive(false);
            Debug.Log("Closed market");
            MarketWindowActive = false;
            Time.timeScale = 1f;
        }
    }
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

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainGameScene");//game scene
    }

    public void GameOver()
    {
        SceneManager.LoadScene("EndGameScene");
    }
    
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SaveGame()
    {
        //SaveSystem.SavePlayer(playerInventory);

    }
}

/* 


*/