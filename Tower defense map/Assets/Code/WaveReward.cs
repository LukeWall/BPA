using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveReward : MonoBehaviour
{
    PlayerStats playerStats;
    WaveSpawner waveSpawner;
    public int waveReward;
    // Start is called before the first frame update
    void Start()
    {
        if(waveSpawner.currentWave>=5 && waveSpawner.currentWave<10)
        {
            waveReward = 500;
        }
        if (waveSpawner.currentWave >= 10 && waveSpawner.currentWave < 15)
        {
            waveReward = 1000;
        }
        if (waveSpawner.currentWave >= 15 && waveSpawner.currentWave < 20)
        {
            waveReward = 1500;
        }
        if (waveSpawner.currentWave >= 20 && waveSpawner.currentWave < 25)
        {
            waveReward = 2000;
        }
        if (waveSpawner.currentWave >= 25 && waveSpawner.currentWave < 30)
        {
            waveReward = 2500;
        }
        if (waveSpawner.currentWave >= 30 && waveSpawner.currentWave < 35)
        {
            waveReward = 3000;
        }
        if (waveSpawner.currentWave >= 35 && waveSpawner.currentWave < 40)
        {
            waveReward = 3500;
        }
        if (waveSpawner.currentWave >= 40 && waveSpawner.currentWave < 50)
        {
            waveReward = 4000;
        }
        if (waveSpawner.currentWave >= 50 && waveSpawner.currentWave < 60)
        {
            waveReward = 5000;
        }
        if (waveSpawner.currentWave >= 60 && waveSpawner.currentWave < 70)
        {
            waveReward = 6000;
        }
        if (waveSpawner.currentWave >= 70 && waveSpawner.currentWave < 80)
        {
            waveReward = 7000;
        }
        if (waveSpawner.currentWave >= 80 && waveSpawner.currentWave < 90)
        {
            waveReward = 8000;
        }
        if (waveSpawner.currentWave >= 90 && waveSpawner.currentWave < 100)
        {
            waveReward = 9000;
        }
        if (waveSpawner.currentWave >= 100)
        {
            waveReward = 10000;
        }
    }
    // Update is called once per frame
    public void GiveWaveReward()
    {
        playerStats.money += waveReward;
    }
}
