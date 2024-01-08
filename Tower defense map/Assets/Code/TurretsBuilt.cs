using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurretsBuilt : MonoBehaviour
{
    public Text turretsBuilt;
    void Update()
    {
        turretsBuilt.text = TotalStats.turretsBuilt.ToString();
    }
}
