using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float Speed;
    public float Health;
    public bool lvl1Enemy;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject);
            gameManager.money += 15;
        }
    }
}
