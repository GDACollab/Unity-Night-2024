using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class JumpScript : MonoBehaviour
{
    // You are a finder of easter eggs!

    private Rigidbody2D rb;
    public float jumpPower = 200;
    public float movePower = 10;
    public float maxSpeed = 50;
    private Boolean prevDirRight = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.AddForce(jumpPower * Vector2.up);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(movePower * Vector2.right);
            prevDirRight = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(movePower * Vector2.right * -1);
            prevDirRight = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        // implementing Dash
        {
            if (prevDirRight)
            {
                rb.AddForce(movePower * Vector2.right);
            } else 
            {
                rb.AddForce(movePower * Vector2.right * -1);
            }
        }
    }
}
