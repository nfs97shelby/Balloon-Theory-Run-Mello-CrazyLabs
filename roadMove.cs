using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class roadMove : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * -1 * speed;
    }
}
