using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float Move_speed = 1.5f;
    public float walkspeed = 0.4f;
    public float Min_X;
    public float Max_X;
    public float Bound_Y = 5.5f;
    
    public bool Moveleft, MoveRight, isbreakable, speedslow, isPlatform;


    void Awake()
    {
        
    }

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
        Invoke("DeactivateObj",4f);
    }

   private void SlowMovement()
    {
       if(Input.GetAxisRaw("Horizontal")>0)
        {
            PlayerMove.rb.velocity = new Vector2(walkspeed, PlayerMove.rb.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            PlayerMove.rb.velocity = new Vector2(-walkspeed, PlayerMove.rb.velocity.y);
        }
    }

   private void DeactivateObj()
    {
        //SoundManager.instance.Icebreak();
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Player")
        {
            if(speedslow)
            {
                SlowMovement();
            }
        }

    }//ontrigerenter

     void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Player")
        {
            if(isbreakable)
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
        if(target.gameObject.tag=="Player")
        {
            if(Moveleft)
            {
                target.gameObject.GetComponent<PlayerMove>().PlatformMove(-1f);
            }
            if(MoveRight)
            {
                target.gameObject.GetComponent<PlayerMove>().PlatformMove(1f);
            }
        }
    }//oncollisionstay

}//class
