using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collCounter : MonoBehaviour
{
    public int cCounter = 0;
    numberOfLives number;

    void Start() 
    {
        number = GameObject.Find("lifeCounter").GetComponent<numberOfLives>();
    }

    void Update()
    {
        GetComponent<Text>().text = cCounter.ToString();

        if (cCounter == 5) 
        {
            number.lives = number.lives + 1;

            cCounter = 0;
        }
    }
}
