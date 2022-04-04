using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject restartPanel;
    public int score1;
    public int score2;
    public Text score1Text;
    public Text score2Text;
    public GameObject Player1WonText;
    public GameObject Player2WonText;
    PlayerMovement player1;
    PlayerMovement player2;
    BallMovement ball;


    private void Start()
    {
        player1 = GameObject.Find("Player 1").GetComponent<PlayerMovement>();
        player2 = GameObject.Find("Player 2").GetComponent<PlayerMovement>();
        ball = GameObject.Find("Ball").GetComponent<BallMovement>();
    }

    public void Score1Calculator(int scoreValue)
    {
        score1 = score1 + scoreValue;
        score1Text.text = score1.ToString();
        ResetGame();
        if (score1 >5)
        {
            restartPanel.SetActive(true);
            Player1WonText.SetActive(true);
            
        }
    }

    public void Score2Calculator(int scoreValue)
    {
        score2 = score2 + scoreValue;
        score2Text.text = score2.ToString();
        ResetGame();
        if (score2 > 5)
        {
            restartPanel.SetActive(true);
            Player2WonText.SetActive(true);
        }
    }

    public void ResetGame()
    {
        ball.RestartPosition();
        player1.RestartGame();
        player2.RestartGame();
    }

    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
