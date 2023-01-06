using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMovey : MonoBehaviour
{

    public float speed;
    public Vector3 direction = Vector3.zero; // (0,0,0)
    bool running = false;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!running)
        {
            StartCoroutine(changeDirection()); 
        }
        transform.position += direction * speed;

         
    }
    
    IEnumerator changeDirection()
    {
        running = true;
        yield return new WaitForSeconds(1);
        direction.x = Random.Range(-1, 2);
        direction.y = Random.Range(-1, 2);
        running = false;
    }
}
