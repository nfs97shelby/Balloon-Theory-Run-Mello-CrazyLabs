using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableMellos : MonoBehaviour
{
    collCounter collcounter;
    AudioSource collecting;

    void Start() 
    {
        collcounter = GameObject.Find("collectableCounter").GetComponent<collCounter>();

        collecting = GameObject.Find("collecting_mellos").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    { 
        print("Collected!");

        collcounter.cCounter++;

        gameObject.SetActive(false);

        collecting.Play();
    }
}
