using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        getComponents();
    }

    private void getComponents()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            changeGravity();
            changeSprite();
        }
    }

    private void changeSprite()
    {
     spriteRenderer.flipY = rb.gravityScale < 0;
    }

    private void changeGravity()
    {
       rb.gravityScale *= -1;
    }

}
