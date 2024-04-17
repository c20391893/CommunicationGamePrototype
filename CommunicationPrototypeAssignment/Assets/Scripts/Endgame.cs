using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject End;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        End.gameObject.SetActive(true);
    }

    
}
