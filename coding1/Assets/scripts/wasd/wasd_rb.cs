using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd_rb : MonoBehaviour
{
    //Variables
    public float forceAmt = 10f;
    private int i = 8;
    private Rigidbody2D rb;

    private Color defaultColor = Color.yellow;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the Rigidbody on the object this script is on 
        rb = GetComponent<Rigidbody2D>();

        //find gameManager
       
    
    
    
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
   
    //OnCollision2D happens when 2D objects with coliders hit eachother
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // make the cube change color when it hits player 2 cube
       if (collision.transform.tag == "Player 2")
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;

        }


       //make the cube change color when it hits player 3
       if (collision.transform.tag == "Player 3")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        //score plus 1
        GameManager.instance.StartGame();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().color = defaultColor;
    }

}
