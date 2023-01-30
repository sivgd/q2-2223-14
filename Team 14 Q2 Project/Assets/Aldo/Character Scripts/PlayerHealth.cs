using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int maxhealth = 100;
    public int currentHealth;
    public HealthBar hBar;
    public static event Action OnPlayerDeath;

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
            OnPlayerDeath?.Invoke();
            gameManager.gameOver();
            Time.timeScale = 0f;
        }

        hBar.SetHealth(health);
        

    }
}
