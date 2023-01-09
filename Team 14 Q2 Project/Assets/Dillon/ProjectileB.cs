
using UnityEngine;

public class ProjectileB : MonoBehaviour
{
    public float Speed = 30f;
    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

    