using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour


{
    public TMP_Text playerScore;
    public int score;
    public bool addScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddPointToScore()
    {
        addScore = true;
        score++;
        playerScore.text = "Marshmallow(s) Collected: " + score.ToString();
        addScore = false;
    }
}
