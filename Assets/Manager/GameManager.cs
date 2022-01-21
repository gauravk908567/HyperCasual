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
        StartCoroutine(timescaleinc());

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
                Application.Quit();
            else
                SceneManager.LoadScene(0);
        }
    }

    public void RestartGame()
    {
        Invoke("RestartAftertime", 2f);
    }

    protected IEnumerator timescaleinc()
    {
        do
        {
            count++;
            yield return new WaitForSeconds(2f);
        }
        while (count <= 0);

        if (count >= 77)
        {
            Time.timeScale += 0.0015f;
            count = 0;
            yield return new WaitForSeconds(5f);
        }
    }
    void RestartAftertime() => SceneManager.LoadScene("Gameplay");

    void GameOver() => SceneManager.LoadScene("GameOver");
}
