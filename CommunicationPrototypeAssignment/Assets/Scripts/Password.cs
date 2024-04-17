using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Password : MonoBehaviour
{
    public GameObject text;
    public GameObject panel;
    private bool PanelActive=false;
    private bool open=false;
    public MouseLook ML;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(open&& Input.GetKeyDown(KeyCode.E))
        {
            if(!PanelActive)
            {
                PanelActive = true;
            }
         else if(PanelActive)
            {
                PanelActive = false;
            }
        }
       if(PanelActive)
        {
            ML.canlook = false;
            text.SetActive(false);
            panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if(!PanelActive)
        {
            ML.canlook = true;
            panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            if (open)
            {
                text.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
        open = true;

       // if(PanelActive)
       // {
        //    panel.SetActive(true);
     //   }
      //  else if(!PanelActive)
      //  {
       //     panel.SetActive(false);
       // }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        PanelActive = false;
        open = false;
    }
}
