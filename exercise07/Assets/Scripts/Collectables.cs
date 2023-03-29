using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{

    ScoreManager sm;

    void Start()
    {

        sm = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sm.AddPointToScore();

            Destroy(this.gameObject);

        }

    }


}