using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 100;
    public int currentHealth;
    public HealthBar hBar;

    private bool isDead;

    public GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        hBar.SetMaxHealth(maxhealth);
        hBar.SetHealth(health);
       
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0 && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
         // gameManager.gameOver();
        }

        hBar.SetHealth(currentHealth);
        

    }
}
