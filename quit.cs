using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
        
        print("You are exiting from the game");
    }
}
