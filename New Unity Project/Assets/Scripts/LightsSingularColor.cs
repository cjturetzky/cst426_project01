using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsSingularColor : MonoBehaviour
{
    public LightsController reference;
    [SerializeField] private Renderer button;
    public bool on = false;

    private void Start()
    {
        button.material.color = Color.black;
    }

     void OnMouseDown()
    {
        if(!on)
        {
            switchLight();
        }
    }

    public void switchLight()
    {
        if (on)
        {
            on = false;
            button.material.color = Color.black;
        }
        else
        {
            on = true;
            button.material.color = Color.white;
            
        }
        reference.checkOn();

    }

    public bool getStatus()
    {
        return on;
    }

    public void win()
    {
        button.material.color = Color.green;
    }
}
