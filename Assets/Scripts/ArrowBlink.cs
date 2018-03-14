using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBlink : MonoBehaviour {

    public Renderer [] arrows;
    public Material greyMat;
    public Material blueMat;
    public float waitTime = 3.0f;


	// Use this for initialization
	void Start () {
		foreach (Renderer arrow in arrows)
        {
            arrow.material = greyMat;
        }

        StartCoroutine("Blink");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Blink()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            if (i == 0)
            {
                arrows[i].material = blueMat;
                yield return new WaitForSeconds(waitTime);
            }
            else if (i>0 && i< (arrows.Length-1))
            {
                arrows[i-1].material = greyMat;
                arrows[i].material = blueMat;
                yield return new WaitForSeconds(waitTime);
            }
            else
            {
                arrows[i - 1].material = greyMat;
                arrows[i].material = blueMat;
                yield return new WaitForSeconds(waitTime);
                arrows[i].material = greyMat;
                i = -1;
            }
        }

        
    }
}
