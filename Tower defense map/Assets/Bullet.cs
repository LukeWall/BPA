using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    EnemyStats enemyStats;
    GameManager gameManager;
    public float speed;
    public GameObject impactEffect;
    
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
            enemyStats.Health -= 10;
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 3f);
            if(enemyStats.Health == 0)
            {
                Destroy(gameObject);
                
                if (tag == "Lvl1Enemy")
                {
                    gameManager.money += 15;
                }
            }
            

        }
    }
}
