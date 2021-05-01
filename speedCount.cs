using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedCount : MonoBehaviour
{
    roadMove roadmove;

    void Start()
    {
        roadmove = GameObject.Find("MovingRoad").GetComponent<roadMove>();
    }

    void Update()
    {
        GetComponent<Text>().text = roadmove.speed.ToString();
    }
}
