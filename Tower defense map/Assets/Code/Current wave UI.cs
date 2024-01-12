using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CurrentwaveUI : MonoBehaviour
{
    Gamemanager gamemanager;
    public Text currentWave;

    //Script for current wave UI
    void Update()
    {
        currentWave.text = Gamemanager.currentWave.ToString(); 
    }
}
