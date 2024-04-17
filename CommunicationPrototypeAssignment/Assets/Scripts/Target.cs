
using UnityEngine;
using UnityEngine.UI;
public class Target : MonoBehaviour
{
    public Text HealthText;
    public GameObject decoder;
    public float health = 100f;
    public void Update()
    {
        HealthText.text = health.ToString();
      //  Debug.Log(health);
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health<=0f)
        {
            if(gameObject.tag=="Enemy")
            {
                Die();
            }

            else if(gameObject.tag=="Commander")
            {
                Instantiate(decoder, gameObject.transform.position, gameObject.transform.rotation);
                Die();
            }
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
