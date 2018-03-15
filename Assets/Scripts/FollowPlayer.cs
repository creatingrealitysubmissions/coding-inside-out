using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour {

    public GameObject myPlayer;
    Transform myPlayerTransfrom;
    Transform myTransform;
    float distance;
    public GameObject black;

    // Use this for initialization
    void Start()
    {

        myTransform = this.GetComponent<Transform>();
        myPlayerTransfrom = myPlayer.transform;
        distance = myPlayerTransfrom.position.z - myTransform.position.z -4;
        StartCoroutine(Example());
    }
    

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(10);
        black.SetActive( false);

    }

    // Update is called once per frame
    void Update()
    {
        if ((myPlayerTransfrom.position.z - distance) > (-13))
        {
            myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, (myPlayerTransfrom.position.z - distance));
        }

        else
        {
            myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, (-13));
        }

        


    }
    
}
