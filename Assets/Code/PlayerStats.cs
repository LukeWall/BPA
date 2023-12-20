using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 250;

    public static int Lives;
    public int startLives = 50;

    public static int Rounds;


    void Start()
    {
        money = startMoney;
        Lives = startLives;

        Rounds = 0;
    }
}
