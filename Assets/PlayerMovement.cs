using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    private float movement;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical1");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
