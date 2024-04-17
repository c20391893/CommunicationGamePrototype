using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Animator anim;


    public ColorTotem T1;
  public  ColorTotem T2;
   public  ColorTotem T3;
    public ColorTotem T4;
    public ColorTotem T5;
    public ColorTotem T6;
    public int T1Correct;
    public int T2Correct;
    public int T3Correct;
    public int T4Correct;
    public int T5Correct;
    public int T6Correct;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Number(int number)
    {
        //  ans.text += number.ToString();
    }

    public void Evaulate()
    {
        {
            if (T1.posCount == T1Correct && T2.posCount == T2Correct && T3.posCount == T3Correct && T4.posCount == T4Correct&& T5.posCount == T5Correct&& T6.posCount == T6Correct)
            {
                Debug.Log("SUCCESS");
                anim.SetBool("Rise", true);
            }
            else
            {
                T1.posCount = 0;
                T2.posCount = 0;
                T3.posCount = 0;
                T4.posCount = 0;
            }
        }
    }
}
