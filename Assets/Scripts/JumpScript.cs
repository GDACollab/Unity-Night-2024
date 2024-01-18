using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpPower = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpPower * Vector2.up);
        }
    }
}
