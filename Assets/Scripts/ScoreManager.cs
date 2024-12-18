using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int currentScore;
    public Text TextScore;

    private void Start()
    {
        currentScore = 0;
    }

    private void Update()
    {
        //TextScore.text = "Score: " + currentScore;
        TextScore.text = "Score: Error";
    }

    public void AddScore(int score)
    {
        currentScore += score;
    }
}
