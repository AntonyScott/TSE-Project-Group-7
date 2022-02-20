using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 movement;
    public float speed;
    public Rigidbody2D playerRb;
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
    }
}
