using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource Ponto;
    public AudioSource GameOverSound;

    [ContextMenu ("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        Ponto.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        Debug.Log("Game restarted");
    }

    public void gameOver()
    {
        Debug.Log("Restarting Game...");
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        GameOverSound.Play();
    }
}
