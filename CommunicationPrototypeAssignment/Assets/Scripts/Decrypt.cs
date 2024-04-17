using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decrypt : MonoBehaviour
{

    public GameObject word;
  //  private GameObject player;
   public PlayerMovement PM;
    public GameObject text;
    public GameObject InputField;
    private bool In;
    private bool Active;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    void Update()
    {
        if(In)
        {
            if(Input.GetKeyDown(KeyCode.LeftAlt))
            {
               if(Active)
                {
                    Active = false;
                   

                }
               else if(!Active)
                {
                    Active = true;
                    
                }
            }
        }

        if(Active)
        {
           // PM.Total = false;
           // PM.freeze = true;
            text.SetActive(false);
            word.gameObject.SetActive(true);
            InputField.gameObject.SetActive(true);
           
        }

       else if(!Active)
        {
           // PM.Total = true;
           // PM.freeze = false;
            word.gameObject.SetActive(false);
            InputField.gameObject.SetActive(false);
            PM.canMove = true;
            if (In)
            {
                text.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            text.SetActive(true);
            In = true;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        In = false;
        Active = false;
      
        
    }
}
