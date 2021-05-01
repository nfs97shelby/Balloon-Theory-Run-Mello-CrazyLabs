using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongRoad : MonoBehaviour
{
    numberOfLives number;
    AudioSource wrongSound;

    void Start() 
    {
        number = GameObject.Find("lifeCounter").GetComponent<numberOfLives>();

        wrongSound = GameObject.Find("wrong_platform").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) 
    {
        number.lives--;

        wrongSound.Play();

        print("Lost one life on wrong road");
    }
}
