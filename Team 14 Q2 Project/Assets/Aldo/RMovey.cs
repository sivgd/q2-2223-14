using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMovey : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Vector3 direction = Vector3.zero; // (0,0,0)
    bool running = false;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!running)
        {
            StartCoroutine(changeDirection()); // change direction
        }
        transform.position += direction * speed;

        // if (Pause.isGamePaused) 
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
