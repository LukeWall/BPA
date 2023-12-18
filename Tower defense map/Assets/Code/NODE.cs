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
     void Update()
     {
        
     }
     public Vector3 GetBuildPosition()
     {
             return transform.position;
         
     }
     void OnMouseDown()
     {
         if (EventSystem.current.IsPointerOverGameObject())
             return;
         if (turret != null)
         {
             Debug.Log("Node Selected");
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
        
        
            Debug.Log("Turret built");
            GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
            turret = _turret;
            PlayerStats.money -= blueprint.cost;

       
        

        turretBlueprint = blueprint;

        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
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

        Debug.Log("Turret Upgraded");
     }
     public void SellTurret()
     {
        PlayerStats.money += turretBlueprint.GetSellAmount();

        Destroy(turret);
        turretBlueprint = null;
     }
    void OnMouseEnter()
    {
        
        if (!buildManager.CanBuild)
            return;
        if(buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
