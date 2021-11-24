using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody ve SpriteRenderer Tanýmlamasý
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        getCompopnents();
    }

    private void getCompopnents()
    {
        //Burada Rigidbody2D ve SpirteRenderer componentlerini baðlayacaðýz GetComponent<> ile
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
        //Burada karakterin sprite özelliðini deðiþteceðiz
        //Karakterin baþ aþaðý gitmesi için sprite flip y yapmak gerekiyor
    }

    private void changeGravity()
    {
       //Burada rigidbody2d üzerinden gravity scale'ý - ile çarpacaðýz
    }

}
