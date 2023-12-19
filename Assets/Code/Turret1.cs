using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret1 : MonoBehaviour
{
    public Transform target;
    public float Range = 15f;

     void Start()
    {
        InvokeRepeating("GetClosestEnemy", 0f, 0.5f);
    }
    void GetClosestEnemy(Transform[] enemies)
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform t in enemies)
        {
            float dist = Vector3.Distance(t.position, currentPos);
            if (dist < minDist)
            {
                tMin = t;
                minDist = dist;
            }
        } 
        if (tMin != null && minDist <= Range)
        {
            target = tMin.transform;
        }
        else
        {
            target = null;
        }
        
    }
    void Update()
    {
        if (target == null)
            return;
    }
}
