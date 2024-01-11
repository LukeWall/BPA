using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static bool GameIsOver = false;
    public Gamemanager gamemanager;
    public GameObject gameOverLoseUI;
    public GameObject gameOverWinUI;
    public int maxWaves = 2;
    public int currentWave;
    
    // Start is called before the first frame update
    void Start()
    {
        
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GameIsOver==true)
        {
            return;
        }
        if (PlayerStats.Lives <= 0)
        {
            EndGameLose();
        }
        

    }
    public void EndGameLose()
    {
        GameIsOver = true;
        gameOverLoseUI.SetActive(true);
        return;
    }
    public void EndGameWin()
    {
        if(currentWave==maxWaves)
            GameIsOver = true;
        gameOverWinUI.SetActive(true);
        return;
    }
    public void WaveCompleted()
    {
        currentWave += 1;
        return;
    }
}
