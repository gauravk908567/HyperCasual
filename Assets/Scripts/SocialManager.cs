using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialManager : MonoBehaviour
{
    private const string linkedin = "https://www.linkedin.com/in/gaurav-kumar-20492818b/";
    private const string github = "https://github.com/gauravk908567";

    public void social(string str)
    {
        switch (str)
        {
            case "linkedin":
                Application.OpenURL(linkedin);
                break;

            case "github":
                Application.OpenURL(github);
                break;

            default:
                Debug.Log("Invalid Selection");
                break;
        }
    }

    void Update()
    {

    }
}
