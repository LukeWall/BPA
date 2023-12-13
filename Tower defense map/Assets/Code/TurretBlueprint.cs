using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBlueprint : MonoBehaviour
{
    //Turret list for shop

    public GameObject prefab;
    public int cost;


    public GameObject upgradedPrefab;
    public int upgradeCost;


    public int GetSellAmount()
    {
        return cost / 2;
    }
}
