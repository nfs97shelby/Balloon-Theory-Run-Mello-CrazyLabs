using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burn : MonoBehaviour
{
    public Texture burningMaterial;
    public Texture basicMaterial;
    Renderer playerRenderer;
    GameObject sweat;
    numberOfLives number;
    AudioSource lavaSound;

    void Start() 
    {
        playerRenderer = GameObject.FindWithTag("Player").GetComponent<Renderer>();

        sweat = GameObject.FindWithTag("Sweat");

        number = GameObject.Find("lifeCounter").GetComponent<numberOfLives>();

        lavaSound = GameObject.Find("lava").GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision) 
    {   
        print("Lost one life");

        number.lives--;

        playerRenderer.material.SetTexture("_MainTex", burningMaterial);

        sweat.transform.localScale = new Vector3(1, 1, 1);

        lavaSound.Play();
    }

    IEnumerator OnCollisionExit(Collision collision) 
    {
        yield return new WaitForSeconds(1);

        playerRenderer.material.SetTexture("_MainTex", basicMaterial);

        sweat.transform.localScale = new Vector3(0, 0, 0);
    }


}
