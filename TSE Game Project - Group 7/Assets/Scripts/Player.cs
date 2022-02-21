using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 movement;
    public float speed;
    public Rigidbody2D playerRb;
    internal bool right = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); //gets the horizontal part for movement
        movement.y = Input.GetAxisRaw("Vertical"); //gets the vertical part of movement 
    }
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movement * speed * Time.fixedDeltaTime); //player moves the the position dictated by movement
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
