using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public GameObject plyr;
    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Player")
        {
            plyr.SetActive(false);
            SoundManager.instance.deathsound();
            GameManager.instance.RestartGame();
        }
    }
}
