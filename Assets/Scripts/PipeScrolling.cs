using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScrolling : MonoBehaviour
{
    private Transform tf;
    [SerializeField]
    private int speed = 5;
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tf.position.x < -20)
        {
            tf.position = new Vector3(40, Random.Range(0, 5.5f), -9);
        }
        tf.Translate(Vector2.left * speed *Time.deltaTime);
    }
}
