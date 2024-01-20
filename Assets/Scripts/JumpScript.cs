using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    // You are a finder of easter eggs!

    private Rigidbody2D rb;
    public float jumpPower = 200;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpPower * Vector2.up);
        }
        // Move Right
        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(moveSpeed * Vector2.right);
        }
        // Move Left
        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(moveSpeed * Vector2.left);
        }
    }
}
