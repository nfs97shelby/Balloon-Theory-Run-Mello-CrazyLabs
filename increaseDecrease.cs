using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseDecrease : MonoBehaviour
{
    roadMove roadmove;

    jump jumpScript;
    
    void Start()
    {
        roadmove = GameObject.Find("MovingRoad").GetComponent<roadMove>();

        jumpScript = GameObject.FindWithTag("MelloAnimation").GetComponent<jump>();
    }

    public void IncreaseSpeed() 
    {
        roadmove.speed++;
    }

    public void DecreaseSpeed() 
    {
        roadmove.speed--;
    }

    public void IncreaseJump() 
    {
        jumpScript.jumpForce = jumpScript.jumpForce + 10;
    }

    public void DecreaseJump()
    {
        jumpScript.jumpForce = jumpScript.jumpForce - 10;
    }
}
