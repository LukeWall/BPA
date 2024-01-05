using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint steamTurret;
    public TurretBlueprint handForgedKatana;
    public TurretBlueprint revolver;
    public TurretBlueprint teslaCoil;

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
    public void SelectHandForgedKatana()
    {
        Debug.Log("HandForged Sword Selected");
        buildManager.SelectTurretToBuild(handForgedKatana);
    }
    public void SelectRevolver()
    {
        Debug.Log("Revolver Selected");
        buildManager.SelectTurretToBuild(revolver);
    }
    public void SelectTeslaCoil()
    {
        Debug.Log("TeslaCoil Selected");
        buildManager.SelectTurretToBuild(teslaCoil);
    }
}
