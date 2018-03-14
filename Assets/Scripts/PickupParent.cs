using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupParent : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    public Transform sphere;
    public Transform player;



    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	void FixedUpdate () {
       device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You are holding touch on the trigger!");
        }
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated touch down on the trigger!");
        }
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated touch up on the trigger!");
        }
        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You are holding press on the trigger!");
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated press down on the trigger!");
        }
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated press up on the trigger!");
        }
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("You have activated press up on the Touchpad!");
            sphere.transform.position = new Vector3(0f, 0f, 0f);
            sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;
            sphere.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.name == "stair") {
            Debug.Log("You have collided with " + col.name + " and activated OnTriggerStay.");
            if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("You have collided with " + col.name + " while holding down touch.");
                col.attachedRigidbody.isKinematic = true;
                col.gameObject.transform.SetParent(this.gameObject.transform);
            }
            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("You have released touch while colliding with " + col.name);
                col.gameObject.transform.SetParent(null);
                col.attachedRigidbody.isKinematic = false;

                tossObject(col.attachedRigidbody);
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "stair")
        {
            player.transform.position = new Vector3(-3.7f, 1.25f, -10.9f);
        }

    }

    void tossObject(Rigidbody rigidbody)
    {
        Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
        if (origin != null)
        {
            rigidbody.velocity = origin.TransformVector(device.velocity);
            rigidbody.angularVelocity = origin.TransformVector(device.angularVelocity);

        }
        else
        {
            rigidbody.velocity = device.velocity;
            rigidbody.angularVelocity = device.angularVelocity;
        }
    }
}
