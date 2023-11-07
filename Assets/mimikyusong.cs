using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class mimikyusong : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbtn;
    private GameObject chan;

    [SerializeField]
    private AudioSource source;

    void Start()
    {
        vbtn = GameObject.Find("mimibutton");
        chan = GameObject.Find("mimikyu");
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        source = GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        source.Play();   
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        source.Pause();
    }
}
