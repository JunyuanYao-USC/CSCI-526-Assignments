using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBallWhenPressSpace : MonoBehaviour
{
    public float speed = 8.0f;

    private Vector3 initialPosition;
    private Rigidbody2D rb;
    private bool shouldMoveHorizontally = true;

    void Start()
    {
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for space key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shouldMoveHorizontally = false;
            rb.gravityScale = 1;
        }

        if (shouldMoveHorizontally)
        {
            MoveHorizontally();
        }

        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);

        // If ball is outside the camera's view
        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        rb.gravityScale = 0;

        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;

        shouldMoveHorizontally = true;

        transform.position = initialPosition;
        transform.rotation = Quaternion.identity;
    }

    private void MoveHorizontally()
    {
        float newX = transform.position.x + speed * Time.deltaTime;

        if (newX > 10 || newX < -10)
        {
            speed = -speed;
        }

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
