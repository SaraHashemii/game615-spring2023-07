using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public CharacterController theCC;
    public float speed = 35;
    public float rotationSpeed = 90;
    public Animator animator;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");


        transform.Rotate(0, rotationSpeed * hAxis * Time.deltaTime, 0);

        if (Mathf.Abs(vAxis) > 0)
        {
            animator.SetBool("walking", true);
           
        }
        else
        {
            animator.SetBool("walking", false);
            
        }

        theCC.Move(transform.forward * speed * vAxis * Time.deltaTime);


    }


}
