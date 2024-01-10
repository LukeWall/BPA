using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static bool GameIsOver = false;
    public Gamemanager gamemanager;
    public static GameObject gameOverLoseUI;
    public static GameObject gameOverWinUI;
    public int maxWaves = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameOverWinUI.SetActive(false);
        gameOverLoseUI.SetActive(false);
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GameIsOver)
        {
            return;
        }
        if (PlayerStats.Lives <= 0)
        {
            EndGameLose();
        }
        else if(WaveSpawner.currentWave==maxWaves)
        {
            EndGameWin();
        }

    }
    void EndGameLose()
    {
        GameIsOver = true;
        gameOverLoseUI.SetActive(true);
    }
    public void EndGameWin()
    {
        GameIsOver = true;
        gameOverWinUI.SetActive(true);
    }
}
