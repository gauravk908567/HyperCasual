using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{

    public float movespeed = 0.3f;
    public float y_scroll;
    public MeshRenderer Meshrend;

    
    // Start is called before the first frame update
    void Awake()
    {
        Meshrend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }

    void scroll()
    {
        y_scroll = Time.time * movespeed;
        Vector2 offset = new Vector2(0f, y_scroll);
        Meshrend.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

}//class
