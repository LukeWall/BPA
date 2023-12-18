using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public float startHealth = 100;
    public float startSpeed = 10f;
    public int worth = 50;
    private float Speed;
    private float health;
    PlayerStats playerStats;
    
    Bullet bullet;

    public Image healthbar;
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Bullet>();
        playerStats = GetComponent<PlayerStats>();
        Speed = startSpeed;
        health = startHealth;
        
    }

    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        health -= amount;

        healthbar.fillAmount = health / startHealth;

        if (health <= 0)
        {
            Debug.Log("Die called");
            Die();
        }
    }

    void Die()
    {
        
        Destroy(gameObject);
        Debug.Log("enemy Destroyed");
        PlayerStats.money += worth;
    }
}
