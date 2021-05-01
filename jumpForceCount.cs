using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpForceCount : MonoBehaviour
{
    jump jumpCount;

    void Start()
    {
        jumpCount = GameObject.FindWithTag("MelloAnimation").GetComponent<jump>();
    }

    void Update()
    {
        GetComponent<Text>().text = jumpCount.jumpForce.ToString();
    }
}
