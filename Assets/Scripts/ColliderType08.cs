using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderType08 : MonoBehaviour {

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
        if (angleY == 0)
        {
            goForward.interactable = true;
        }
        else
        {
            goForward.interactable = false;
            goBackwards.interactable = false;
        }
    }
}
