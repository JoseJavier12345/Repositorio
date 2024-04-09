using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interraccion : MonoBehaviour
{
    public GameObject panel;

    private void Start() 
    {
        PanelOff();
    }

    public void PanelOn()
    {
        panel.SetActive(true);
    }
    
    public void PanelOff()
    {
        panel.SetActive(false);
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PanelOn();
        }
   }

   private void OnTriggerExit(Collider other) 
   {
    PanelOff();
   }
}
