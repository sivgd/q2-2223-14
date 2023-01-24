using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            //animator.SetTrigger
        } 
    }
}
