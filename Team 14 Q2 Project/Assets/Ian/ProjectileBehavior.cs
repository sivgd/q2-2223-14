using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4.5f;

    private void Update()
    {
        transform.position += transform.right * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyBehaviour>();
        if (enemy)
        {
           enemy.TakeHit(1);
        }

        Destroy(gameObject);
    }

}
