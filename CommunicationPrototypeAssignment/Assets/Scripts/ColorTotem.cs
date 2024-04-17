using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTotem : MonoBehaviour
{
    public GameObject text;
    public GameManager gm;
    //  public int answer;
    //  public GameObject lightBox;
    public Light lit;
    public int posCount;
   // public BoxCollider bc1;
    private bool In;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (In)
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                posCount++;



                Debug.Log(posCount);

            }
        }
        if (posCount == 0)
        {
            lit.color = Color.black;
        }
        else if (posCount == 1)
        {
            lit.color = Color.blue;
        }
        else if (posCount == 2)
        {
            lit.color = Color.red;
        }
        else if (posCount == 3)
        {
            lit.color = Color.gray;
        }
        else if (posCount == 4)
        {
            lit.color = Color.yellow;
        }
        else if (posCount == 5)
        {
            lit.color = Color.green;
        }
        else if (posCount == 6)
        {
            lit.color = Color.magenta;
        }
        if (posCount >= 7)
        {
            posCount = 0;
        }

    }

    private void OnTriggerEnter(Collider other1)
    {

        Debug.Log("ÏN");
        if (other1.tag == "Player")
        {
            text.SetActive(true);
            Debug.Log("IN");
            In = true;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        In = false;
    }

}
