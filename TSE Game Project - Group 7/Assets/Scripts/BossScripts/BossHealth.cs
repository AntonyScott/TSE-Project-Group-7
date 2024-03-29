using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 200;
    public int currentHealth;

    public BossHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
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

        healthBar.Sethealth(currentHealth);
        FindObjectOfType<AudioManager>().Play("Hit");

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

