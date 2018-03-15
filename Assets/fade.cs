using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour
{
    public float time = 5; //Seconds to read the text

    void Start()
    {
        Destroy(gameObject, time);
    }
}