using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightsController : MonoBehaviour
{
    public int lightsOn;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public ParticleSystem win;

    public void checkOn()
    {
        lightsOn = 0;
        if (button1.GetComponent<LightsSingularColor>().on)
            lightsOn++;
        if (button2.GetComponent<LightsSingularColor>().on)
            lightsOn++;
        if (button3.GetComponent<LightsSingularColor>().on)
            lightsOn++;
        if (button4.GetComponent<LightsSingularColor>().on)
            lightsOn++;


        if(lightsOn == 4)
        {
            Debug.Log("All lights are on!");
            win.Play();
        }
    }

    
}
