using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playButton : MonoBehaviour
{
    GameObject welcomeScreen;
    roadMove roadmove;

    void Start()
    {
        welcomeScreen = GameObject.Find("WelcomeScreen");

        roadmove = GameObject.Find("MovingRoad").GetComponent<roadMove>();
    }

    public void onPlayClicked()
    {
        Destroy(welcomeScreen);

        roadmove.speed = 8;
    }
}
