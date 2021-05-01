using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector2 startTouchPosition, endTouchPosition;
    bool isGrounded;
    public Transform groundCheck;

    void FixedUpdate() 
    {
        isGrounded = Physics.Raycast(groundCheck.position, -transform.up, 0.2f);
    }
    
    void Update()
    {
        swipeMove();   
    }

    void swipeMove()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -4 && isGrounded)
            {
                transform.position = new Vector3(transform.position.x - 4, transform.position.y, transform.position.z);
            }

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 3 && isGrounded)
            {
                transform.position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
            }
        }
    }
}
