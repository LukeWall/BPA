using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Transform target;
    
    [Header("Attributes")]
    public float range;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
   
    [Header("Unity Setup Fields")]
    public Transform partToRotate;
    public float turnSpeed = 10f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    //public Transform firePoint2;

    Turret1 turret1;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        turret1 = GetComponent<Turret1>();
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject neareastEnemy = null;
        foreach(GameObject Enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, Enemy.transform.position);
            if(distanceToEnemy <= shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                neareastEnemy = Enemy;
            }
            if (neareastEnemy != null && shortestDistance <=range)
            {
                target = neareastEnemy.transform;
            }
            else
            {
                target = null;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            partToRotate.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


        //target lock on
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
            partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }

        if (target != null && fireCountdown<=0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //GameObject bulletGo2 = (GameObject)Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Bullet bullet = bulletGo.GetComponent<Bullet>();
        //Bullet bullet2 = bulletGo2.GetComponent<Bullet>();

        if (bullet != null)
            bullet.Seek(target);
    }   
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

