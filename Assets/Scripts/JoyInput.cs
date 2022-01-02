using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyInput : MonoBehaviour
{
    public static Joystick joystick;
    public static Rigidbody2D rbody;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(joystick.Horizontal * 3f, rbody.velocity.y);
    }
}
