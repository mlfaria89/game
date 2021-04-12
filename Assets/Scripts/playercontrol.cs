using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movevel;
    private bool ismoving = false;
    Vector2 moveinput = new Vector2(0, 0);


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (!ismoving)
        {
            moveinput.x = 0;
        }
       

        if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
        {
            ismoving = true;
            
            //position in line
            
            
                moveinput.x = 1;
            
        }


        if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0)
        {
            ismoving = true;

            //position in line


            moveinput.x = -1;

        }

        if (Input.GetButtonUp("Horizontal"))
        {
            ismoving = false;
        }


            // Vector2 moveinput = new Vector2(Input.GetAxis("Horizontal"), 0);


            if (rb.position.x <= -23.3f && moveinput.x <= 0)
        {
            moveinput.x = 0;
        }

        if (rb.position.x >= 25.88f && moveinput.x >= 0)
        {
            moveinput.x = 0;
        }





       
        
            movevel = moveinput.normalized * speed;
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movevel * Time.fixedDeltaTime);
    }
}
