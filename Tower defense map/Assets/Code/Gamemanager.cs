using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static bool GameIsOver = false;
    public Gamemanager gamemanager;
    public GameObject gameOverLoseUI;
    public GameObject gameOverWinUI;
    public int maxWaves = 31;
    public static int currentWave;
    
    
    void Start()
    {
        
        GameIsOver = false;
    }

   
    void Update()
    {
        
        if(GameIsOver==true)
        {
            return;
        }
        if (PlayerStats.Lives <= 0)
        {
            EndGameLose();
        }//if player has no lives remaining calls a method
        

    }
    public void EndGameLose()
    {
        GameIsOver = true;
        gameOverLoseUI.SetActive(true);
        return;
    }//when method is called sets the LoseAI as active
    public void EndGameWin()
    {
        if(currentWave==maxWaves)
            GameIsOver = true;
        gameOverWinUI.SetActive(true);
        return;
    }//when method is called sets WinUI as active
    public void WaveCompleted()
    {
        currentWave += 1;
        return;
    }//when wave is completed adds 1 to the current wave count
}
