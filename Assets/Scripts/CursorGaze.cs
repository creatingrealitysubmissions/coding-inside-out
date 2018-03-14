using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorGaze : MonoBehaviour {

    public float sightlength = 100.0f;
    public GameObject selectedObj;

    private void FixedUpdate()
    {
        RaycastHit seen;
        Ray raydirection = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(raydirection, out seen, sightlength))
        {
            if (seen.collider.tag == "cursor")
            {
              //is more logic needed or is here where an event can be triggered?
                //ideal action would be some kind of progress bar and first scene loaded
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
