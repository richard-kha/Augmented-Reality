using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour
{
    private Animation anime;
    // Use this for initialization
    void Start()
    {
        anime = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        anime.Play("idle");
    }
}
