using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    EnemyStats enemyStats;
    PlayerStats playerStats;
    public float speed;
    public int damage;
    public GameObject impactEffect;

    public void Start()
    {
        enemyStats = GetComponent<EnemyStats>();
        playerStats = GetComponent<PlayerStats>();
    }
    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if (target==null)
        {
            Destroy(gameObject);
            return;
        }

            Vector3 dir = target.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;


            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }


            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        
        void HitTarget()
        {
            Debug.Log("WE HIT SOMETHING");
            Damage(target);
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 3f);
            
            

        }
        void Damage (Transform enemy)
        {
            EnemyStats e = enemy.GetComponent<EnemyStats>();

            if (e != null)
            {
                e.TakeDamage(damage);
            }

            Destroy(gameObject);
        }

    }
}
