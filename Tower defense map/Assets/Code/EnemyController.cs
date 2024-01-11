using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemyStats enemyStats;


    
    
    private Transform target;
    
    public int wavepointIndex = 0;
    Waypoints waypoint;
   
     void Start()
    {
        target = Waypoints.points[0];
        enemyStats = GetComponent<EnemyStats>();
        waypoint = GetComponent<Waypoints>();
    }

     void Update()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion rot = target.rotation;
        transform.Translate(dir.normalized  * EnemyStats.Speed * Time.deltaTime, Space.World);
        transform.LookAt(target);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        
        
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            PlayerStats.Lives -= EnemyStats.livesDamage;
            EndPath();
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex]; 
    }
   
    public void EndPath()
    {
        
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);

        
    }
}
