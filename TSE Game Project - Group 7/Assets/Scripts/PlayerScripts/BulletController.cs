using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    public float speed;
    Vector3 direction;
    void Start()
    {
        
        player = GameObject.Find("Player");
        direction = (player.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Walls")
        {
            Destroy(this.gameObject);
        }
    }
}
