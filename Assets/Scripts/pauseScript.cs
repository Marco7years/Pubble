using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour
{
    bool isPaused = false;
 
    /*
    public void pauseGame()
    {
        Debug.Log("Is working");

        if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
    }*/

    void onMouseDown()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Time.timeScale = 1f;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0f;
                isPaused = true;
            }
        }
    }
}
