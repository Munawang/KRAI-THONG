using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    private float moveSpeed;
    private bool moveRight;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 1f)
        {
            moveRight = false;
        }
        else if (transform.position.y < -1.5f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
    }
}
