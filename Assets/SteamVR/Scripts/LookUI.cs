using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookUI : MonoBehaviour {

    public bool isReady = false;
    public SteamVR_LaserPointer myLaser;

    public Color activeColor;
    public Color transparentColor;
    // Use this for initialization
    void Start()
    {
        myLaser.color = transparentColor;
    }
    void OnTriggerEnter(Collider other)
    {
        myLaser.color = activeColor;
        isReady = true;
    }
    void OnTriggerExit(Collider other)
    {
        myLaser.color = transparentColor;
        isReady = false;
    }

}

