using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyLeft : MonoBehaviour
{
    //UI for Enemies Left Counter
    public Text enemyCount;
    WaveSpawner waveSpawner;
    void Update()
    {
        enemyCount.text = WaveSpawner.EnemiesAlive.ToString();
    }

}
