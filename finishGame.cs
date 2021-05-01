using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishGame : MonoBehaviour
{
    roadMove roadmove;
    Animator playerAnimator;
    Renderer playerRenderer;
    public Canvas WinScreen;
    public Canvas LoseScreen;
    public Canvas HUD;
    AudioSource victory;

    void Start() 
    {
        roadmove = GameObject.Find("MovingRoad").GetComponent<roadMove>();
        
        playerAnimator = GameObject.FindWithTag("MelloAnimation").GetComponent<Animator>();
        
        playerRenderer = GameObject.FindWithTag("Player").GetComponent<Renderer>();

        victory = GameObject.Find("victory").GetComponent<AudioSource>();
    }

    IEnumerator OnCollisionEnter(Collision collision) 
    {
        print("You won the game!");

        yield return new WaitForSeconds(0.3f);

        roadmove.speed = 0;

        playerRenderer.material.color = Color.white;

        playerAnimator.enabled = false;

        LoseScreen.GetComponent<Canvas>().enabled = false;

        HUD.GetComponent<Canvas>().enabled = false;

        WinScreen.GetComponent<CanvasGroup>().alpha = 1;

        victory.Play();
    }
}
