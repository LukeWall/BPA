using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;


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

    //public NodeUI nodeUI;
    

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

               // nodeUI.SetTarget(node);
               //(Make nodeUI later
    }           
    public void DeselectNode()
    {
                selectedNode = null;
            //    nodeUI.Hide();
    }
    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }
    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
