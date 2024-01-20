using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    // You are a finder of easter eggs!

    private Rigidbody2D rb;
    public float jumpPower = 200;
    public float speed = 10;
    public float dashSpeed = 100;

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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(Vector2.right * Input.GetAxis("Horizontal") * dashSpeed);
        }
        // Left/Right Movement
        rb.AddForce(Vector2.right * Input.GetAxis("Horizontal") * speed);
    }
}
