using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class lol : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbtn;
    private GameObject chan;

    [SerializeField]
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        vbtn = GameObject.Find("chanbutton");
        chan = GameObject.Find("unitychan");
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
