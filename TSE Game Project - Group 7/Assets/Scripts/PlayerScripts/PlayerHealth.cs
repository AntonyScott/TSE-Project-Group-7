using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< Updated upstream
        if (collision.tag == "HealthPickup")
        {
            GainHealth(30);
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Enemy")
=======
        if (collision.tag == "EnemyBullet")
>>>>>>> Stashed changes
        {
            TakeDamage(10);
            Destroy(collision.gameObject);
        }
    }

    void GainHealth(int health)
    {
        currentHealth += health;

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            
        }

        healthBar.Sethealth(currentHealth);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.Sethealth(currentHealth);

        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
