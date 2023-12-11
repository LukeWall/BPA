using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public float startHealth = 100;
    public float startSpeed = 10f;
    public int worth;
    public float Speed;
    private float health;
    GameManager gameManager;



    public Image healthbar;
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
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
        GameManager.money += worth;
    }
}
