using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public static int startLiveDamage = 1;
    public float startHealth = 100;
    public float startSpeed = 10f;
    public int worth = 50;
    public static float Speed;
    public static float health;
    public static int livesDamage;
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
        livesDamage = startLiveDamage;
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
        TotalStats.enemiesKilled++;
        Destroy(gameObject);
        Debug.Log("enemy Destroyed");
        PlayerStats.money += worth;
        WaveSpawner.EnemiesAlive--;
    }
}
