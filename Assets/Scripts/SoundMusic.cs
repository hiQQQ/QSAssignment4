using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMusic : MonoBehaviour
{

    public Camera cam;

    void Start()
    {
        cam.GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        
    }
}
