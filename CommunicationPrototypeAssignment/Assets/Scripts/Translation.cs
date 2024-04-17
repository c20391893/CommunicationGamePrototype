using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translation : MonoBehaviour
{
    public GameObject Evaluation;
  public GameObject CorrectText;
    private GameObject player;
    private PlayerMovement Pm;
    public string answer;
    public string theName;
   // public InputField clearit;
    public InputField inputField;
   // public GameObject textDisplay;
    void Start()
    {
      //  CorrectText.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoreName()
    {
        theName = inputField.text;
        inputField.text = "";
        // textDisplay.GetComponent<Text>().text = "Welcome" + theName + "to the game";
        if(theName==answer)
        {
            Evaluation.gameObject.SetActive(true);
            inputField.text = theName;
            inputField.enabled = false;
            Debug.Log("Done");
            CorrectText.SetActive(true);
           // StartCoroutine(CoolDown());
        }
        else
        {
            inputField.Select();
            inputField.text = "";
            
        }
    }

  //  public IEnumerator CoolDown()
  //  {
       // yield return new WaitForSeconds(2f);
      //  CorrectText.SetActive(false);
  //  }
}
