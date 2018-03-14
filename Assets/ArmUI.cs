using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmUI : MonoBehaviour {

    public Button growUp;
    public Button shrink;
    public Button goForward;
    public Button goBackwards;
    public Button turnLeft;
    public Button turnRight;
    public Transform player;

    float currentPositionx;
    float currentPositiony;
    float currentPositionz;
    public float currentRotation;


    // Use this for initialization
    void Start () {

        growUp.onClick.AddListener(GrowUp);
        shrink.onClick.AddListener(Shrink);
        goForward.onClick.AddListener(GoForward);
        goBackwards.onClick.AddListener(GoBackwards);
        turnLeft.onClick.AddListener(TurnLeft);
        turnRight.onClick.AddListener(TurnRight);
        currentRotation = player.rotation.y;

    }

    // Update is called once per frame
    void GrowUp()
    {

        currentPositionx = player.position.x;
        currentPositiony = player.position.y;
        currentPositionz = player.position.z;
        player.position = new Vector3(player.position.x, (player.position.y+0.5f), player.position.z);

    }
    void Shrink()
    {

        currentPositionx = player.position.x;
        currentPositiony = player.position.y;
        currentPositionz = player.position.z;
        player.position = new Vector3(player.position.x, (player.position.y - 0.5f), player.position.z);

    }

    void GoForward () {

        currentPositionx = player.position.x;
        currentPositiony = player.position.y;
        currentPositionz = player.position.z;
        player.position = new Vector3(player.position.x, player.position.y, (player.position.z-1));

    }
    void GoBackwards()
    {

        currentPositionx = player.position.x;
        currentPositiony = player.position.y;
        currentPositionz = player.position.z;
        player.position = new Vector3(player.position.x, player.position.y, (player.position.z + 1));

    }
    void TurnLeft()
    {
        player.Rotate(0, (-90), 0);

    }
    void TurnRight()
    {
        player.Rotate(0, 90, 0);
    }
}
