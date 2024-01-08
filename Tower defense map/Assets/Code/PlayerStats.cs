using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 250;
    
    public static int Lives;
    public int startLives;
    public static int Rounds;

    WaveSpawner waveSpawner;


    void Start()
    {
        
        money = startMoney;
        Lives = startLives;

        Rounds = 0;
        
        
    }
    
}
