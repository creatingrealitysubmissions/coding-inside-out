using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour {
    public bool isReady = false;
    // Use this for initialization

    void OnTriggerEnter (Collider other)
    {
        isReady = true;
    }

}
