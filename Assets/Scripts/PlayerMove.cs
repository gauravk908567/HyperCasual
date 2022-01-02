using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{

    public float Plspeed = 5f;
    //public float slowspeed = 2.5f;
    public static Rigidbody2D rb;
    //float horizontalmove = 0f;
    /* for 1920 * 1080 platform spawn are 2.08to 2.1*/
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Move();

        //if(fixedJoystick.Horizontal >= 0.01f)
        //{
        //    horizontalmove = Plspeed;
        //}
        //else 
        //    if(fixedJoystick.Horizontal <= -0.01f)
        //{
        //    horizontalmove = -Plspeed;
        //}
        //else
        //{
        //    horizontalmove = 0f;
        //}
    }
    public void Move()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 temp = transform.position;
            temp.x -= Plspeed * Time.deltaTime;
            transform.position = temp;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 temp = transform.position;
            temp.x += Plspeed * Time.deltaTime;
            transform.position = temp;
        }
    }

    //public void SlowMovement()
    //{
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        Vector2 temp = transform.position;
    //        temp.x -= slowspeed * Time.deltaTime;
    //        transform.position = temp;
    //    }
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        Vector2 temp = transform.position;
    //        temp.x += slowspeed * Time.deltaTime;
    //        transform.position = temp;
    //    }
    //}

    public void PlatformMove(float x)
    {
        rb.velocity = new Vector2(x, rb.velocity.y);
    }

}//class
