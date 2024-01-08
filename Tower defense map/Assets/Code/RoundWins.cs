using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoundWins : MonoBehaviour
{
    public Text Roundwins;
    // Update is called once per frame
    void Update()
    {
        Roundwins.text = TotalStats.roundsCompleted.ToString();
    }
}
