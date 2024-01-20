using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    // You are a finder of easter eggs!

    private Rigidbody2D rb;
    public float jumpPower = 200;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpPower * Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(jumpPower * Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce((jumpPower/2) * Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce((jumpPower/2) * Vector2.right);
        }
    }
}
