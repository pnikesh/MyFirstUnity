using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void FixedUpdate()
    {
        // listem for perticuler key to be presed
        /*
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,5);
            GetComponent<Rigidbody2D>().gravityScale = -1;
        }
         */

        //real way of doing input
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        
        
        //Debug.Log("x:  "+  horiz + "y:  " +  vert);

        Vector2 newVelocity = new Vector2(horiz,vert);

        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;




        //move my character based on thoes buttons press


    }
}
