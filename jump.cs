using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody playerRigidbody;
    public float jumpForce = 450f;
    Animator playerAnimator;
    bool isGrounded;
    public Transform groundCheck;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        playerAnimator = GameObject.FindWithTag("MelloAnimation").GetComponent<Animator>();
    }


    void FixedUpdate() 
    {
        isGrounded = Physics.Raycast(groundCheck.position, -transform.up, 0.2f);
    }
    void Update()
    {
        doubleTapJump();
    }

    void doubleTapJump()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(i).tapCount == 2 && isGrounded)
                {
                    playerRigidbody.AddForce(Vector2.up * jumpForce);
                }
            }
        }

        if (playerRigidbody.velocity.y > 0 && !isGrounded)
        {
            playerAnimator.Play("Jump");
        }

        if (playerRigidbody.velocity.y < 0 && !isGrounded)
        {
            playerAnimator.Play("Fall");
        }

        if (isGrounded)
        {
            playerAnimator.Play("Run");
        }

    }
}
