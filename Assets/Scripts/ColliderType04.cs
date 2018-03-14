using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderType04 : MonoBehaviour {

    GameObject myPlayer;
    public float angleY;

    public Button goForward;
    public Button goBackwards;


    private void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
        angleY = myPlayer.transform.rotation.eulerAngles.y;
    }


    void OnTriggerStay(Collider other)
    {
        angleY = myPlayer.transform.rotation.eulerAngles.y;
        if (angleY == 180)
        {
            goForward.interactable = true;
            goBackwards.interactable = false;
        }
        else
        {
            goForward.interactable = false;
            goBackwards.interactable = false;
        }
    }
}
