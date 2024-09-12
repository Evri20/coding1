using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd_rb : MonoBehaviour
{
    //Variables
    public float forceAmt = 10f;
    private int i = 8;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the Rigidbody on the object this script is on 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //if statement to move right on screen by using D
        if (Input.GetKey(KeyCode.D))
    {
            //make the rigid body move right 
            rb.AddForce(Vector2.right * forceAmt);
        }
   // make the rigidbody move left
   if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceAmt);
        }
    //make rigidbody move up
    if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceAmt);
        }
    //make rigidbody move down
    if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceAmt);
        }
    }
}
