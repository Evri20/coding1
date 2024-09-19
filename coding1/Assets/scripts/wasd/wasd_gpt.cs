using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd_gpt : MonoBehaviour
{
    //variables
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;



    // Start is called before the first frame update
    void Start()
    {
        // fnd rigidbody
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // get input from wasd keys
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        movement = new Vector2(moveX, moveY).normalized;

    }

    // fixed update is called on a fixed value of frames
    private void FixedUpdate()
    {
        // move the player
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
