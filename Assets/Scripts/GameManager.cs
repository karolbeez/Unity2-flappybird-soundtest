using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {

        bestScoreText.text = PlayerPrefs.GetInt("Points").ToString();
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        if (points > PlayerPrefs.GetInt("Points"))
        {
            PlayerPrefs.SetInt("Points", points);
        }
        else if (points < PlayerPrefs.GetInt("Points"))
        {

        }

        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
    }
}
