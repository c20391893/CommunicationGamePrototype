using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float mouseSensitivity = 10f;
    public float damage;
   // public float range = 100f;
    float xRotation;
    public GameObject bullet;
    public float shootForce;
    public Camera fpsCam;
    public MouseLook ml;
    public Transform attackpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ml.canlook)
        {


            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        /* RaycastHit hit;
         if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
         {
             Debug.Log(hit.transform.name);

            Target target= hit.transform.GetComponent<Target>();
             if(target!=null)
             {
                 target.TakeDamage(damage);
             }
         }
        */
        Ray ray = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75);

        Vector3 directionWithoutSpread = targetPoint - attackpoint.position;

        GameObject currentBullet = Instantiate(bullet, attackpoint.position, Quaternion.identity);
        currentBullet.transform.forward = directionWithoutSpread.normalized;
        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithoutSpread.normalized * shootForce, ForceMode.Impulse);
    }
}
