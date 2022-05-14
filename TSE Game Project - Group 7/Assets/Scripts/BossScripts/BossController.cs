using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class BossController : MonoBehaviour
{
    public Transform target;
    public Transform alien;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;
    public Transform boss;
    public GameObject bullet;
    Path currentPath;
    int currentWaypoint = 0;
    bool end = false;
    //private float timer = 0.5f;
    Seeker seeker;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdatePath", 0f, .5f);
        InvokeRepeating("Shoot", 0f, 3f);
    }
    void UpdatePath()
    {
        if (seeker.IsDone()) seeker.StartPath(rb.position, target.position, PathCompleted); //otherwise a path is created for the alien to follow
    }
    void PathCompleted(Path p)
    {
        if (!p.error)
        {
            currentPath = p;
            currentWaypoint = 0;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentPath == null) return;
        if (currentWaypoint >= currentPath.vectorPath.Count)
        {
            end = true;
            return;
        }
        else end = false;
        Vector2 direction = ((Vector2)currentPath.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position, currentPath.vectorPath[currentWaypoint]);
        if (distance < nextWaypointDistance) currentWaypoint++;
        if (rb.velocity.x >= 0.01f) alien.localScale = new Vector3(1f, 1f, 1f);
        else if (rb.velocity.x <= 0.01f) alien.localScale = new Vector3(-1f, 1f, 1f); //how the enemy follows the player
    }
    void Shoot()
    {
        foreach(Transform child in boss)
        {
            Instantiate(bullet, child.position, child.rotation);
        }
    }
}
