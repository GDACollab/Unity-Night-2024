using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float horizontalSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(horizontalSpeed * Vector2.left);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(horizontalSpeed * Vector2.right);
        }
    }
}
