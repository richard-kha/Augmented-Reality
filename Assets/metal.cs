using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class metal : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbtn;
    private GameObject chan;

    [SerializeField]
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        vbtn = GameObject.Find("metalbutton");
        chan = GameObject.Find("Trash Dove");
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
