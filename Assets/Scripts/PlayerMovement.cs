using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;   // Speed of movement
    public float jumpForce = 5f;   // Force applied when jumping
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move(); // Call the move function each frame
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");  // Input from left/right arrow keys or A/D
        float moveY = Input.GetAxis("Vertical");    // Input from up/down arrow keys or W/S

        Vector3 move = transform.forward * moveX + transform.up * moveY; // Calculate movement direction
        
        rb.MovePosition(transform.position + move * moveSpeed * Time.deltaTime); // Move the player
    }
}
