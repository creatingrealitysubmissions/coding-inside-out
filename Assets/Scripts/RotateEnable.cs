using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnable : MonoBehaviour {

    public GameObject[] icons;
    public GameObject[] uiButtons;
    public GameObject[] flyText;
    public GameObject firstText;

    public GameObject[] uiImages;
    public GameObject[] uiImages2;

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


        if (currentIcon < icons.Length)
        {
            if (colliders[currentIcon].isReady == true)
            {
                currentIcon++;
            }
        }

        

        if (currentIcon == 0)
        {
            icons[currentIcon].GetComponentInChildren<Renderer>().material = iconMat;
            icons[currentIcon].GetComponentInChildren<Light>().enabled = true;
            flyText[currentIcon].SetActive(true);
            uiImages[currentIcon].SetActive(true);
            uiImages2[currentIcon].SetActive(true);
        }
        else if (currentIcon < (icons.Length))
        {
            firstText.SetActive(false);
            icons[currentIcon].GetComponentInChildren<Renderer>().material = iconMat;
            icons[currentIcon].GetComponentInChildren<Light>().enabled = true;
            flyText[currentIcon].SetActive(true);
            icons[currentIcon - 1].GetComponentInChildren<Renderer>().material = greyMat;
            icons[currentIcon - 1].GetComponentInChildren<Light>().enabled = false;
            
            flyText[currentIcon -1].SetActive(false);
            uiButtons[currentIcon - 1].SetActive(true);
            uiImages[currentIcon-1].SetActive(false);
            uiImages[currentIcon ].SetActive(true);
            uiImages2[currentIcon - 1].SetActive(false);
            uiImages2[currentIcon].SetActive(true);
        }
        else
        {
            icons[currentIcon - 1].GetComponentInChildren<Renderer>().material = greyMat;
            uiButtons[currentIcon - 1].SetActive(true);
            uiImages[currentIcon ].SetActive(true);
            uiImages2[currentIcon].SetActive(true);
        }

        if (currentIcon < icons.Length)
        {
            icons[currentIcon].transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }

        

    }    
    
}
