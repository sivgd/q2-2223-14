using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public bool grounded = false;
    public float MovementSpeed = 7;
    Rigidbody2D rb2;
    SpriteRenderer sr;
    Animator a;

    public ProjectileBehaviorr ProjectilePrefab;
    public Transform LaunchOffset;
    private bool fire;
    public float Sprinting = 1.0f;
    private bool sprint;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        a = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 0.1f), 0, Vector2.down, 2, LayerMask.GetMask("Ground"));

        a.SetFloat("yVelocity", rb2.velocity.y);
        a.SetBool("Grounded", grounded);
        a.SetBool("Throw", fire);
        a.SetBool("Fast", sprint);
       

        float horizvlaue = Input.GetAxis("Horizontal");

        if (horizvlaue == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //sprinting
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MovementSpeed += Sprinting;
            sprint = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            MovementSpeed -= Sprinting;
            sprint = false;
        }

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2.velocity = new Vector2(rb2.velocity.x, 6);
        }

        if (Input.GetButtonDown("Fire1"))
        {
           Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
            fire = true;
        }
        else

        if (Input.GetButtonUp("Fire1"))
        {
            fire = false;
        }

    }
}
