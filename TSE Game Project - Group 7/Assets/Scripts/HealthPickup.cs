using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;

    public int healthBonus = 30;

    private void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthBonus;
        }
    }
}
