using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock_camera : MonoBehaviour {

    GameObject myPlayer;
    private void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(myPlayer.transform);
    }
}
