using UnityEngine;
using System.Collections;


public class Ctrl : MonoBehaviour
{
	private Rigidbody2D rb;
    public float jumpPower = 200;
	public float speed = 1.5f;

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddForce(jumpPower * Vector2.up);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}
}