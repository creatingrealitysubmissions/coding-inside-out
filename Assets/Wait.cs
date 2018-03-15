using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wait : MonoBehaviour {

    // Use this for initialization
    public Transform player;
    public GameObject image;
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        player.transform.position = new Vector3(-1.48f, 0f, 3.5f);
        print(Time.time);
        yield return new WaitForSeconds(10);
        player.transform.position = new Vector3(-1.48f, 0f, -.5f);
        print(Time.time);
        image.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
