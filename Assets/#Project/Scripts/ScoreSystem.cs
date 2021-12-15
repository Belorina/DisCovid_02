using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{

    public int score;
    public int highscore;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highscoreUI;

    void Start()
    {
        scoreUI.text = "score: " + 0;
        Load();

    }

    void Update()
    {
        scoreUI.text = "score: " + score.ToString();
        highscoreUI.text = "highscore: " + highscore.ToString();

        if (score > highscore)
        {
            highscore = score;
            Save();
        }

    }

    public void AddScore(int amount)
    {
        score += amount;
        Save();
    }

    public void SubstractScore(int amount)
    {
        score -= amount;
        Save();
    }

    public void Save()
    {
        //PlayerPrefs.SetInt("score", score);

        PlayerPrefs.SetInt("highscore", highscore);
    }

    public void Load()
    {
        //score = PlayerPrefs.GetInt("score");
        highscore = PlayerPrefs.GetInt("highscore");
    }

}
