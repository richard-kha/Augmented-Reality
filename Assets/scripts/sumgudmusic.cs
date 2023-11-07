using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class sumgudmusic : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour track;
    public  AudioSource source;
    private AudioClip clip;


    // Use this for initialization
    void Start ()
    {
        GetComponent<AudioClip>();
        GetComponent<AudioSource>();
        track = GetComponent<TrackableBehaviour>();
        if (track)
        {
            track.RegisterTrackableEventHandler(this);
            Debug.Log("testing");
        }
	}

    public void OnTrackableStateChanged (TrackableBehaviour.Status pre, TrackableBehaviour.Status newer)
    {
        if (newer == TrackableBehaviour.Status.DETECTED ||
            newer == TrackableBehaviour.Status.TRACKED ||
            newer == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            source.Play();
           Debug.Log("working?");
        }
        else
        {
            source.Stop();
        }
    }
}