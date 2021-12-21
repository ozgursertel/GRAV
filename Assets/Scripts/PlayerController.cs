using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    public float runningSpeed;

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
        if (Input.GetMouseButtonDown(0) && GameController.Instance.isGameStarted && !GameController.Instance.isGameEnded)
        {
            changeGravity();
            changeSprite();
        }
        
    }
    private void FixedUpdate()
    {
        if (GameController.Instance.isGameStarted)
        {
            rb.MovePosition(transform.position + Vector3.right * Time.deltaTime * runningSpeed);
        }
        if(transform.position.y < -5.5f || transform.position.y > 5.5f){
            GameController.Instance.Death();
        }
        
    }
    private void changeSprite()
    {
        AudioManager.instance.Play("Jump");
        spriteRenderer.flipY = rb.gravityScale < 0;
    }

    private void changeGravity()
    {
       rb.gravityScale *= -1;
    }

}
