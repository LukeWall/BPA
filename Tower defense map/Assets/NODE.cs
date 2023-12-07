using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NODE : MonoBehaviour
{

    public Color hoverColor;

    private GameObject turret;

    public Vector3 positionOffset;



    private Renderer rend;
    private Color startColor;
     void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
      if(turret !=null)
        {
            Debug.Log("Can't Build there!");
            return;
        }

        //Build turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
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
