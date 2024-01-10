using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    PlayerStats playerStats;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one build manager in scene");
        }
        instance = this;
    }
    public GameObject buildEffect;
    public GameObject sellEffect;

    private TurretBlueprint turretToBuild;
    private NODE selectedNode;

    public NodeUI nodeUI;
    

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.money >= turretToBuild.cost; } }

    public void SelectNode (NODE node)
    {
         if (selectedNode == node)
         {
                    DeselectNode();
                    return;
         }
         selectedNode = node;
         turretToBuild = null;

               nodeUI.SetTarget(node);
               //finds if a node is selected
    }           
    public void DeselectNode()
    {//deselects node when called 
                selectedNode = null;
                nodeUI.Hide();
    }
    public void SelectTurretToBuild (TurretBlueprint turret)
    {//player turret selection
        turretToBuild = turret;
        DeselectNode();
        Debug.Log("Turret selected");
    }
    public TurretBlueprint GetTurretToBuild()
    {//gets build program the turret selection
        return turretToBuild;
    }
}
