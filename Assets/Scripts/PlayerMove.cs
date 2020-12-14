using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float Plspeed = 5f;    
    public static Rigidbody2D rb;
    
   
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 temp = transform.position;
            temp.x -= Plspeed * Time.deltaTime;
            transform.position = temp;
        }
        if(Input.GetKey(KeyCode.D))
        {
            Vector2 temp = transform.position;
            temp.x += Plspeed * Time.deltaTime;
            transform.position = temp;
        }
    }

    public void PlatformMove(float x)
    {
        rb.velocity = new Vector2(x, rb.velocity.y);
    }
    

}//class
