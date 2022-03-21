using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    GameObject player;
    Rigidbody2D bulletRb;
    public float speed = 1f;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        bulletRb = GetComponent<Rigidbody2D>();
        direction = (player.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime; //bullet moves towards player
    }
}
