using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
       Target target= other.GetComponent<Target>();
        if(target!=null)
        {
            target.TakeDamage(10);
            Destroy(gameObject);
        }

         else if(other.tag=="Decoder")
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);

    }
}
