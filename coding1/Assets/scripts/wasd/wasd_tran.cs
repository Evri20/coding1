using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd_tran : MonoBehaviour
{
    //variables
    public float speed = 3f;
    public GameObject pl2;
    private bool spawn = true;
    public GameManager gameManager;

    
    
    // Start is called before the first frame update
    
    //awake happens before start
    private void Awake()
    {
        pl2 = this.gameObject;
        gameManager = FindObjectOfType<GameManager>();
    
    }

    // Update is called once per frame
    void Update()
    {
       /*
        // find the position of the object every frame and make a vector
        Vector2 pos = transform.position;
       
        
        // if i press right arrow move the position to the right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }

        // if press left arrow move the position to the left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }
    
        // if press up arrow move the position up
        if(Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
    
        // if press down arrow move posititon down
        if(Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }

        transform.position = pos;
       */
     }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        
        //only spawn if true
        if (spawn)
        {
            
            spawn = false;
            if(collision.transform.tag == "Player")
            {
                gameManager.sc_num++;
            }else if (collision.transform.tag == "Player 3")
            {
                gameManager.p3sc_num++;
            }

            //spawn pl2
            var pos = new Vector2(Random.Range(-9, 8), Random.Range(-3, 4));
            Instantiate(pl2, pos, Quaternion.identity);
            //destroy player
            Destroy(this.gameObject);
            spawn = true;
        
        }
    
        
        }
    // x(-9, - 8.6) y(3, - -3)





}
