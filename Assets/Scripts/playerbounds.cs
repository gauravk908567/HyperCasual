using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbounds : MonoBehaviour
{

    public float min_X = -5.86f, max_X = 5.86f, min_Y = -5.34f;
    private bool OutBound;
    void Update()
    {
        checkbound();
    }

    void checkbound()
    {
        Vector2 temp = transform.position;

        if(temp.x>max_X)
        {
            temp.x = max_X;
        }

        if(temp.x<min_X)
        {
            temp.x = min_X;
        }

        transform.position = temp;

        if(temp.y<=min_Y)
        {
            if(!OutBound)
            {
                OutBound = true;
                SoundManager.instance.deathsound();
                GameManager.instance.RestartGame();
            }
        }
    }//checkbounds

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag== "Spikestop")
            
        {
            transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.deathsound();
            GameManager.instance.RestartGame();
        }
    }

}
