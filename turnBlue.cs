using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnBlue : MonoBehaviour
{
    Renderer playerRenderer;
    Color myBlue;

    void Start()
    {
        playerRenderer = GameObject.FindWithTag("Player").GetComponent<Renderer>();

        myBlue = new Color(0.5411f, 0.7019f, 1, 1);
    }

    void OnTriggerEnter(Collider other)
    {
        playerRenderer.material.color = myBlue;
    }
}
