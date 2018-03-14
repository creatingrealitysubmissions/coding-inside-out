using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderType01 : MonoBehaviour {

    GameObject myPlayer;
    public float angleY;
    public bool check = false;

    public Button goForward;
    public Button goBackwards;


    private void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
        angleY = myPlayer.transform.rotation.eulerAngles.y;
    }


    void OnTriggerStay(Collider other)
    {
        //if (other.tag == ("head"))
        //{
        //    check = true;
        //    angleY = myPlayer.transform.rotation.eulerAngles.y;

        //    if (angleY != 180)
        //    {
        //        goForward.interactable = false;
        //        goBackwards.interactable = false;
        //    }
        //    else
        //    {
        //        goForward.interactable = true;
        //        goBackwards.interactable = true;
        //    }
        //}

        check = true;
        angleY = myPlayer.transform.rotation.eulerAngles.y;

        if (angleY != 180)
        {
            goForward.interactable = false;
            goBackwards.interactable = false;
        }
        else
        {
            goForward.interactable = true;
            goBackwards.interactable = true;
        }
    }
}
