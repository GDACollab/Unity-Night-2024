
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movescript : MonoBehaviour
{
    // You are a finder of easter eggs!

    private Rigidbody2D rb;
    public float movePower = 200;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightApple))
        {
            rb.AddForce(movePower * Vector2.right);
        }

        if (Input.GetKey(KeyCode.LeftApple))
        {
            rb.AddForce(movePower * Vector2.left);
        }

        if(Math.Abs(rb.position.x) > 15) {
            Debug.Log("foo");
            rb.position = new Vector2(0, 5);
        }
    }
}
