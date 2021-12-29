using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int count = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        Time.timeScale = 1f;
    }
    private void Update()
    {
        time();
    }

    public void RestartGame()
    {
        Invoke("RestartAftertime", 2f);
    }

    void time()
    {

        do
        {
            count++;

        }
        while (count <= 0);
        
        if (count >= 77)
        {
            Time.timeScale += 0.001f;
            count = 0;
        }
        
    }
    void RestartAftertime() => SceneManager.LoadScene("Gameplay");

    void GameOver() => SceneManager.LoadScene("GameOver");
}
