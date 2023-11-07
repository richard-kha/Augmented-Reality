using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movement : MonoBehaviour {

    private Rigidbody chan;
    private Animation anime;


	// Use this for initialization
	void Start ()
    {
        chan = GetComponent<Rigidbody>();
        anime = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        anime.Play("idle");
    }
}
