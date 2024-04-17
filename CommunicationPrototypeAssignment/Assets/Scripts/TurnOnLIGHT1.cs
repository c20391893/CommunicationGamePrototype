using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLIGHT1 : MonoBehaviour
{
   public GameManager gm;
    public GameObject text;
    public int num;
    public GameObject lightBox;
    private Light lit;
    public int posCount;
    public BoxCollider bc;
    private bool In;
    // Start is called before the first frame update

    private void Start()
    {
        lit = lightBox.GetComponent<Light>();
        bc.gameObject.GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        if(In)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
               // bc.gameObject.SetActive(false);
                posCount = num;
                gm.Number(posCount);
                lightBox.SetActive(true);
                text.SetActive(false);
               
              
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {

      //  Debug.Log("ÏN");
        if (other.tag=="Player")
        {
            text.SetActive(true);
            In = true;
        }
        

    }

    public void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        In =false; 
    }
}
