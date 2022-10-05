using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject ball;

    public GameObject player1Paddle;
    public GameObject player1Goal;

    public GameObject player2Paddle;
    public GameObject player2Goal;

    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;
    
    public void Player1Scored(){
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        WinnerCheck();
        ResetPosition();
    }
    public void Player2Scored(){
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        WinnerCheck();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<PlayerMovement>().Reset();
        player2Paddle.GetComponent<PlayerMovement>().Reset();
    }

    private void WinnerCheck(){
        if (Player1Score >= 5){
            SceneManager.LoadScene(2);
        } 
        if (Player2Score >= 5){
            SceneManager.LoadScene(3);
        }
    }
}
