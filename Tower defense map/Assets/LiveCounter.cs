using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LiveCounter : MonoBehaviour
{
    //UI for Lives left 

    public Text liveCount;
    
    void Update()
    {
        liveCount.text = PlayerStats.Lives.ToString();
    }

}
