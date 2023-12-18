using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemyStats enemyStats;


    
    
    private Transform target;
    
    public int wavepointIndex = 0;
   
   
     void Start()
    {
        target = Waypoints.points[0];
        enemyStats = GetComponent<EnemyStats>();

    }

     void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized  * enemyStats.startSpeed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        
        
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
           
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex]; 
    }
}
