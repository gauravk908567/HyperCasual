using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text ScoreText;
    public Text Highscoretext;

    public int score = 0;
    public int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        ScoreText.text = score.ToString();
        Highscoretext.text = highscore.ToString();
    }

    public void AddPoints()
    {
        score += 1;
        ScoreText.text = score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
