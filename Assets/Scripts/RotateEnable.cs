using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnable : MonoBehaviour {

    public GameObject[] icons;
    public GameObject[] uiButtons;

    public GameObject[] uiImages;

    public CheckCollider[] colliders;

    public float speed = 20.0f;

    public Material greyMat;
    public Material iconMat;

    int currentIcon = 0; 
    
	void Start () {
              
        foreach (GameObject icon in icons)
        {
            icon.GetComponentInChildren<Light>().enabled = false;
            icon.GetComponentInChildren<Renderer>().material = greyMat;
        }

        foreach (GameObject but in uiButtons)
        {
            but.SetActive(false);
        }

        colliders = new CheckCollider[icons.Length];
        for (int i = 0; i < icons.Length; i++)
        {
            colliders[i] = icons[i].GetComponent<CheckCollider>();
        }
	}
	
	void Update () {


        if (colliders[currentIcon].isReady == true)
        {
            colliders[currentIcon].isReady = false;
            currentIcon++; 
        }

        if (currentIcon == 0)
        {
            icons[currentIcon].GetComponentInChildren<Renderer>().material = iconMat;
            icons[currentIcon].GetComponentInChildren<Light>().enabled = true;
            uiImages[currentIcon].SetActive(true);
        }
        else
        {
            icons[currentIcon].GetComponentInChildren<Renderer>().material = iconMat;
            icons[currentIcon].GetComponentInChildren<Light>().enabled = true;
            icons[currentIcon - 1].GetComponentInChildren<Renderer>().material = greyMat;
            icons[currentIcon - 1].GetComponentInChildren<Light>().enabled = false;
            uiButtons[currentIcon - 1].SetActive(true);
            uiImages[currentIcon-1].SetActive(false);
            uiImages[currentIcon ].SetActive(true);
        }

        icons[currentIcon].transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }    
    
}
