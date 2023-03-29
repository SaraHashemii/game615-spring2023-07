using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject NotFinished;
    public GameObject NiceJob;

    public Animator animUI;
    ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("Canvas").GetComponent<ScoreManager>();
        NotFinished.SetActive(false);
        NiceJob.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void isButtonPressed()
    {
        if (sm.score == 5)
        {
            animUI.SetBool("ButtonPressed", true);
            NiceJob.SetActive(true);
        }
        else
        {
            animUI.SetBool("ButtonPressed", true);
            NotFinished.SetActive(true);
            Invoke("Resume", 1f);




            //Debug.Log("You clicked");
            //collectText.text = "yay";
            //collectText.text = counterForCollected.ToString();
            //if (counterForCollected == 0)
            //{
            //    collectText.text = "You collected all the Marshmellows! You will have a great snack for the afternoon!";
            //    //include particle effect when button is pressed 


            //    //display particle effect on 0 

            //    for (int i = 0; i < 30; i++)
            //    {
            //        GameObject marshobj = Instantiate(CollectableMarshmellow, gameObject.transform.position, Quaternion.identity);
            //        float rotXAmount = Random.Range(-89, -10);
            //        float rotYAmount = Random.Range(0, 360);
            //        marshobj.transform.Rotate(rotXAmount, rotYAmount, 0);
            //        Rigidbody forMarsh = marshobj.GetComponent<Rigidbody>();
            //        forMarsh.AddForce(marshobj.transform.forward * 1000);

            //        Destroy(marshobj, 2f);
            //    }
            //}



        }


    }

    public void Resume()
    {
        animUI.SetBool("ButtonPressed", false);
        NotFinished.SetActive(false);

    }
}



