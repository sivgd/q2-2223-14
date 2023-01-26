using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 20;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //playerHealth.TakeDamage(damage);
            player.GetComponent<PlayerHealth>().TakeDamage(damage);
            Debug.Log("ouch");
          //  player.Components.Animator.TryPlayAnimation("TakeDamage");
        }
    }
}
