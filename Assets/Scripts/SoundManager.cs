using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField]
    private AudioSource soundFX;
    [SerializeField]
    private AudioClip landclip, deathclip, icebreakclip, gameoverclip;
    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    public void landsound()
    {
        soundFX.clip = landclip;
        soundFX.Play();

    }

    public void icebreak()
    {
        soundFX.clip = icebreakclip;
        soundFX.Play();
    }

    public void deathsound()
    {
        soundFX.clip = deathclip;
        soundFX.Play();
    }
    public void gameover()
    {
        soundFX.clip = gameoverclip;
        soundFX.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
