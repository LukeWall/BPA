using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurretsUpgraded : MonoBehaviour
{
    public Text upgrades;

    // Update is called once per frame
    void Update()
    {
        upgrades.text = TotalStats.turretsUpgraded.ToString();
    }
}
