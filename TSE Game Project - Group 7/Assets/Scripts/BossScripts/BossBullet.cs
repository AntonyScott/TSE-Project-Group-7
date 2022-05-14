using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    GameObject boss;
    Transform bossTransform;
    Rigidbody2D bulletRb;
    public float speed = 1f;
    Vector3 direction;
    List<Vector3> directions;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.Find("Boss");
        bossTransform = boss.GetComponent<Transform>();
        bulletRb = GetComponent<Rigidbody2D>();
        direction = transform.position;
        Debug.Log(direction);
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = direction * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Walls")
        {
            Destroy(this.gameObject);
        }
    }
}
