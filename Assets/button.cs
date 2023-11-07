using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class button : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbtn;
    private GameObject chan;

    [SerializeField]
    private AudioSource source;
    //private AudioClip clip;

    // Use this for initialization
    void Start()
    {
        vbtn = GameObject.Find("buttonchan");
        chan = GameObject.Find("mrino");
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        source = GetComponent<AudioSource>();
        //clip = GetComponent<AudioClip>();
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button pressed");
        source.Play();
        
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Let go of button");
        source.Pause();
        
    }
}
  