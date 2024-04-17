using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoder : MonoBehaviour
{
    private GameObject GM;
    private GameManager gameCode;

    private void Start()
    {
        GM = GameObject.Find("GameManager");
        gameCode = GM.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
         //   Debug.Log("Item Collected");
          //  gameCode.collection += 1;
            Destroy(gameObject);
        }

        
    }
}
