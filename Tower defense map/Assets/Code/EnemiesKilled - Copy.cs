using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemieskilled : MonoBehaviour
{
    public Text killsText;

    public void update()
    {
        killsText.text = TotalStats.enemiesKilled.ToString();
    }

}
