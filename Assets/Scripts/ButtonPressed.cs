using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour {

    Button myButton;
    
    // Use this for initialization
	void Start () {
        myButton = this.GetComponent<Button>();
        myButton.onClick.AddListener(Pressed);
    }
	
	// Update is called once per frame
	void Pressed () {
        Debug.Log("Button pressed");
	}
}
