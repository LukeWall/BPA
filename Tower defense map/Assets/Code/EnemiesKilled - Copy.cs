using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemieskilled : MonoBehaviour
{
    public Text killsText;
    //UI for totalstats (total kills)
    public void update()
    {
        killsText.text = TotalStats.enemiesKilled.ToString();
    }

}
