using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicController : MonoBehaviour
{
    public Camera cam;
    void Start()
    {
        cam.GetComponent<AudioSource>().Play();
    }
}
