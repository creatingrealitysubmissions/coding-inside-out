using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderType07 : MonoBehaviour {

    GameObject myPlayer;
    public float angleY;

    public Button goForward;
    public Button goBackwards;
    public Button turnLeft;
    public Button turnRight;


    private void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
        angleY = myPlayer.transform.rotation.eulerAngles.y;
    }


    void OnTriggerStay(Collider other)
    {
        goForward.interactable = true;
        goBackwards.interactable = false;
        turnLeft.interactable = false;
        turnRight.interactable = false;
    }
}
