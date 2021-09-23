
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public void IncrementScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
    }
    public void IncrementScore1()
    {
        score+=5;
        ScoreText.text = "Score: " + score;
    }
}