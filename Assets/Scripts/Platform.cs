using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float Move_speed = 1.5f;
    public float slow_speed = 2.2f;
    public float walkspeed = 0.4f;
    public float Min_X;
    public float Max_X;
    public float Bound_Y = 5.5f;
    
    public bool Moveleft, MoveRight, isPlatform;

 
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 temp = transform.position;
        temp.y += Move_speed * Time.deltaTime;
        transform.position = temp;

        if(temp.y>=Bound_Y)
        {
            gameObject.SetActive(false);
        }
    }//move

   private void BreakableDeactivate()
    {
        Invoke("DeactivateObj",0.7f);
    }
    /*
   private void SlowMovement()
    {
       if(Input.GetAxisRaw("Horizontal")>0)
        {
            PlayerMove.Plspeed -= 2f;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            PlayerMove.Plspeed -= 2f;
        }
    }
    */
   private void DeactivateObj()
    {
        //SoundManager.instance.Icebreak();
        gameObject.SetActive(false);
    }

    /*private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Player")
        {
            if(this.gameObject.tag=="SpeedSlow")
            {
                SlowMovement();
            }
        }
    
    }//ontrigerenter
    */
     void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Player")
        {
            if(this.gameObject.tag=="Breakable")
            {
                SoundManager.instance.landsound();
                BreakableDeactivate();
             
            }
            if(isPlatform)
            {
                SoundManager.instance.landsound();
            }
        }
    }//oncollision Enter

    void OnCollisionStay2D(Collision2D target)
    {
        if(target.gameObject.tag == "Player" && this.gameObject.tag == "Movement_platform")
        {
            if(Moveleft)
            {
                target.gameObject.GetComponent<PlayerMove>().PlatformMove(-2f);
            }
            if(MoveRight)
            {
                target.gameObject.GetComponent<PlayerMove>().PlatformMove(2f);
            }
        }

        if(target.gameObject.tag == "Player" && this.gameObject.tag == "SpeedSlow")
        {
            if (Input.GetKey(KeyCode.A))
            {
                Vector2 temp = transform.position;
                temp.x -= slow_speed * Time.deltaTime;
                transform.position = temp;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector2 temp = transform.position;
                temp.x += slow_speed * Time.deltaTime;
                transform.position = temp;
            }
        }
    }//oncollisionstay

}//class
