using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpScript : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    InputAction jumpAction;
    
    // You are a finder of easter eggs!

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public float jumpPower = 200;
    public float movePower = 5;
    public float maxSpeed = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Movement");
        jumpAction = playerInput.actions.FindAction("Jump");
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (/* Input.GetKeyDown(KeyCode.Space) */jumpAction.triggered && rb.velocity.y ==0)
        {
            rb.AddForce(jumpPower * Vector2.up);
        }
        
        if(moveAction.ReadValue<Vector2>().x>0){
            rb.AddForce(movePower*Vector2.right);
        }
        else if(moveAction.ReadValue<Vector2>().x<0){
            rb.AddForce(movePower*Vector2.left);
        }
        
        if (rb.velocity.x < 0){
            sprite.flipX = true;
        }
        else if (rb.velocity.x > 0){
            sprite.flipX = false;
        }
        
        if(rb.velocity.magnitude > maxSpeed)
        {
               rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
