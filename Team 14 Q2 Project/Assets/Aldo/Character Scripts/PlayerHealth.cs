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
   // public GameObject player;
    //private bool ouch;
    Animator a;
    public float timeBetweenDamage = 1.0f;
    private float lastDamageTime;

    private bool isDead;

    public GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        hBar.SetMaxHealth(maxhealth);
        hBar.SetHealth(health);
        a = gameObject.GetComponent<Animator>();
    }

    public void TakeDamage(int amount)
    {

        if (Time.time > lastDamageTime + timeBetweenDamage)
        {
            health -= amount;
            a.SetTrigger("Damaged");
            a.SetBool("IsTakingDamage", true);
            lastDamageTime = Time.time;
          
        }
       
        

        if (health <= 0 && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
            OnPlayerDeath?.Invoke();
            gameManager.gameOver();
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        hBar.SetHealth(health);
    }
    private void Update()
    {
        if (Time.time > lastDamageTime + timeBetweenDamage)
        {
            a.SetBool("IsTakingDamage", false);
        }
    }
}

