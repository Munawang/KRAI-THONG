using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(speed * moveX, rb.velocity.y);

        float moveY = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * moveY, rb.velocity.x);
    }
}
