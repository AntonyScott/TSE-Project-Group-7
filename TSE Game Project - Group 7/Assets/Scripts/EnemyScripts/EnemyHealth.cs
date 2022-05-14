using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public GameObject healthPickUp;
    bool healthSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        healthSpawn = Random.value > 0.5f;
        Debug.Log(healthSpawn);
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            TakeDamage(10);
            Destroy(collision.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        FindObjectOfType<AudioManager>().Play("Hit");

        if (currentHealth <= 0)
        {
            if (healthSpawn) Instantiate(healthPickUp, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}
