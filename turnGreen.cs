using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnGreen : MonoBehaviour
{
    Renderer playerRenderer;
    Color myGreen;

    void Start()
    {
        playerRenderer = GameObject.FindWithTag("Player").GetComponent<Renderer>();
        
        myGreen = new Color(0.5411f, 0.9921f, 0.7333f, 1);
    }

    void OnTriggerEnter(Collider other)
    {
        playerRenderer.material.color = myGreen;
    }
}
