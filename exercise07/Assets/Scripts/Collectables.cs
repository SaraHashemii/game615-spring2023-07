using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    static int score;
    public TMP_Text scoreText;
    public TMP_Text timerText;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            score++;
            SetScoreText();

            Destroy(this.gameObject);

        }

    }

    void SetScoreText()
    {
        scoreText.text = "Marshmallow(s) Collected: " + score;
    }
}