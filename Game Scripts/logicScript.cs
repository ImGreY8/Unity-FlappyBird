 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scrollText;
    public Text endScoreText;
    public GameObject gameOverScreen, gameOverScore, gameStartScreenPipe, gameStartScreenBird, 
    closeGameStartScreen, startScoretext, BGMstopObject;
    public gameBGMscript bgm; 
    public void addScore(int scoreIn)
    {
        playerScore += scoreIn;
        scrollText.text = playerScore.ToString();
        endScoreText.text = playerScore.ToString();
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverScore.SetActive(true);
    }

    public void gameStart()
    {
        gameStartScreenBird.SetActive(true);
        gameStartScreenPipe.SetActive(true);
        closeGameStartScreen.SetActive(false);
        startScoretext.SetActive(true);  
    }
}