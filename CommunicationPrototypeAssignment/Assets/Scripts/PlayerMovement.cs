using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    [Space]
    public CharacterController controller;
    public Transform groundcheck;
    public LayerMask groundMask;
    public GameObject text;
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;
    [Space]

    [Header("Variables")]
    [Space]
   private bool Riddle=false;
    public bool freeze = false;
    public bool toQ=true;
    public bool toE=true;
    public bool Total;
    private bool pause;
    private bool toP=true;
    public bool canMove = true;
    private bool Tranlation = false;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 1f;

    [Header("Other")]
    [Space]
    public MouseLook ML;
  
  
   // public GameObject crosshair;

    public float groundDistance = 0.4f;
    

    Vector3 velocity;
    bool isGrounded;
    private void Start()
    {
        Total = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {


            isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetButton("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }





        if (Total==true)
        {
            if (toQ)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    if (Riddle)
                    {
                        Riddle = false;
                        toE = true;
                      toP = true;
                    }
                    else if (!Riddle)
                    {
                        Riddle = true;
                        toE = false;
                        toP = false;
                    }
                }
            }

            if (toE)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {

                    if (Tranlation)
                    {
                        Tranlation = false;
                        toQ = true;
                        toP = true;
                    }
                    else if (!Tranlation)
                    {
                        Tranlation = true;
                        toQ = false;
                        toP = false;
                    }
                }
            }


           if(toP)
            {
                if(Input.GetKeyDown(KeyCode.Alpha3))
                {
                    if(pause)
                    {
                        pause = false;
                        toQ = true;
                        toE = true;

                    }

                   else if(!pause)
                    {
                        pause = true;
                        toQ = false;
                       toE = false;
                    }
                }
            }
        }
        
      if(Riddle)
        {
            Panel.SetActive(true);  
        }
         if(!Riddle)
        {
            Panel.SetActive(false);
        }

         if(Tranlation)
        {
            Panel2.SetActive(true);
        }

         if(!Tranlation)
        {
            Panel2.SetActive(false);
        }

         if(pause)
        {
            Panel3.SetActive(true);
        }

         if(!pause)
        {
            Panel3.SetActive(false);
        }
         if(freeze)
        {
            Time.timeScale = 0f;
        }
         if(!freeze)
        {
            Time.timeScale = 1f;
        }
        
    }
}
