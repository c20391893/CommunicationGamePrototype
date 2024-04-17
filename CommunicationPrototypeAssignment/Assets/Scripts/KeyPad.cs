using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [Header("Text")]
    [Space]
    [SerializeField] private Text ans;
    private string Answer = "1234";
    [Space]

    [Header("Buttons")]
    [Space]
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button buttonEnter;
    [Space]


    [Header("GameObjects")]
    [Space]
    public GameObject door;
    [Space]
    [Header("Animators")]
    private Animator anim;
  

    private void Start()
    {
        anim = door.GetComponent<Animator>();
    }
    public void Number(int number)
    {
        ans.text += number.ToString();
    }


    public void Execute()
    {
        if(ans.text == Answer)
        {
            ans.text = "Good";
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            button4.interactable = false;
            button5.interactable = false;
            button6.interactable = false;
            button7.interactable = false;
            button8.interactable = false;
            button9.interactable = false;
            buttonEnter.interactable = false;
            anim.SetBool("Open", true);
        }
        else
        {
            ans.text = "Error";
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;
            button4.interactable = false;
            button5.interactable = false;
            button6.interactable = false;
            button7.interactable = false;
            button8.interactable = false;
            button9.interactable = false;
            buttonEnter.interactable = false;
            StartCoroutine(CoolDown());
        }
    }

 public IEnumerator CoolDown()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(2f);
        Debug.Log("End");
        ans.text = "";
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
        button4.interactable = true;
        button5.interactable = true;
        button6.interactable = true;
        button7.interactable = true;
        button8.interactable = true;
        button9.interactable = true;
        buttonEnter.interactable = true;
    }
}
