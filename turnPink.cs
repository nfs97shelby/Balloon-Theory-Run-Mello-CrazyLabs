using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnPink : MonoBehaviour
{
    Renderer playerRenderer;
    Color myPink;

    void Start()
    {
        playerRenderer = GameObject.FindWithTag("Player").GetComponent<Renderer>();
        
        myPink = new Color(0.9921f, 0.5411f, 0.9607f, 1);
    }

    void OnTriggerEnter(Collider other)
    {
        playerRenderer.material.color = myPink;
    }
}
