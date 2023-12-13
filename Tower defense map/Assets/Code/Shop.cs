using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint steamTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectSteamTurret()
    {
        Debug.Log("Steam Turret selected");
        buildManager.SelectTurretToBuild(steamTurret);
    }
}
