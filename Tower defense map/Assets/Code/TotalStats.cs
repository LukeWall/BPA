using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalStats : MonoBehaviour
{
    public static int roundsCompleted;
    public static int enemiesKilled = 0;
    public static int turretsBuilt;
    public static int turretsUpgraded;
    // Start is called before the first frame update
    void Start()
    {
        roundsCompleted = PlayerStats.Rounds;
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
