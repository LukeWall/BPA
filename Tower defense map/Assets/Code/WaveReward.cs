using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveReward : MonoBehaviour
{
    PlayerStats playerStats;
    WaveSpawner waveSpawner;
    public static int waveReward;
    // Start is called before the first frame update
    void Start()
    {
        if(WaveSpawner.currentWave>=5 && WaveSpawner.currentWave<10)
        {
            waveReward = 500;
        }
        if (WaveSpawner.currentWave >= 10 && WaveSpawner.currentWave < 15)
        {
            waveReward = 1000;
        }
        if (WaveSpawner.currentWave >= 15 && WaveSpawner.currentWave < 20)
        {
            waveReward = 1500;
        }
        if (WaveSpawner.currentWave >= 20 && WaveSpawner.currentWave < 25)
        {
            waveReward = 2000;
        }
        if (WaveSpawner.currentWave >= 25 && WaveSpawner.currentWave < 30)
        {
            waveReward = 2500;
        }
        if (WaveSpawner.currentWave >= 30 && WaveSpawner.currentWave < 35)
        {
            waveReward = 3000;
        }
        if (WaveSpawner.currentWave >= 35 && WaveSpawner.currentWave < 40)
        {
            waveReward = 3500;
        }
        if (WaveSpawner.currentWave >= 40 && WaveSpawner.currentWave < 50)
        {
            waveReward = 4000;
        }
        if (WaveSpawner.currentWave >= 50 && WaveSpawner.currentWave < 60)
        {
            waveReward = 5000;
        }
        if (WaveSpawner.currentWave >= 60 && WaveSpawner.currentWave < 70)
        {
            waveReward = 6000;
        }
        if (WaveSpawner.currentWave >= 70 && WaveSpawner.currentWave < 80)
        {
            waveReward = 7000;
        }
        if (WaveSpawner.currentWave >= 80 && WaveSpawner.currentWave < 90)
        {
            waveReward = 8000;
        }
        if (WaveSpawner.currentWave >= 90 && WaveSpawner.currentWave < 100)
        {
            waveReward = 9000;
        }
        if (WaveSpawner.currentWave >= 100)
        {
            waveReward = 10000;
        }
    }
    // Update is called once per frame
    public static void GiveWaveReward()
    {
        PlayerStats.money += waveReward;
    }
}
