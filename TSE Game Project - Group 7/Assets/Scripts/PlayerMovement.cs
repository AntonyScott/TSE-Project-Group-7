using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    internal bool right = true;

    Vector2 movement;

    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement.normalized * movementSpeed * Time.fixedDeltaTime);

        if (movement.x < 0 && right) //if the player is moving left but the sprite is facing right
        {
            Flip();
        }
        else if (movement.x > 0 && !right) //if the player is moving right but the sprite is facing left
        {
            Flip();
        }
    }
    private void Flip() //used to flip the sprite
    {
        right = !right;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
