using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    private bool isDead;

    public GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    void Update()
    {
      //healthBar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);
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

        healthBar.SetHealth(currentHealth);

    }
}
