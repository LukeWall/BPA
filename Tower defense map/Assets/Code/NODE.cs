using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NODE : MonoBehaviour
{

    public Color hoverColor;
    public Color notEnoughMoneyColor;

    public Vector3 positionOffset;

    [HideInInspector]
    public GameObject turret;
    [HideInInspector]
    public TurretBlueprint turretBlueprint;
    [HideInInspector]
    public bool isUpgraded = false;

    private Renderer rend;
    private Color startColor;
    
    BuildManager buildManager;
     void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosistion()
    {
        return transform.position + positionOffset;
    }
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (turret != null)
        {
            buildManager.SelectNode(this);
            return;
        }

        if (!buildManager.CanBuild)
            return;

        BuildTurret(buildManager.GetTurretToBuild());
    }
    void BuildTurret(TurretBlueprint blueprint)
    {
        if(PlayerStats.money < blueprint.cost)
        {
            Debug.Log("Not enough money to build that");
            return;
        }

        PlayerStats.money -= blueprint.cost;

        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        turretBlueprint = blueprint;

        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosistion(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret build!");
    }
    public void UpgradeTurret()
    {
        if (PlayerStats.money < turretBlueprint.upgradeCost)
        {
            Debug.Log("Not enough money to upgrade");
            return;
        }
        PlayerStats.money -= turretBlueprint.upgradeCost;

        //get rid of old turret
        Destroy(turret);

        //build new one
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        isUpgraded = true;

    }
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
