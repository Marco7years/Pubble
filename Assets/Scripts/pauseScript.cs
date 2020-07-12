using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour
{
    public bool pause;

    // Start is called before the first frame update
    void Start()
    {
        pause = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPause()
    {
        pause = !pause;
        if(!pause)
        {
            Time.timeScale = 1;
            GameControl.instance.isPaused = false;
        } else if(pause) {
            Time.timeScale = 0;
            GameControl.instance.isPaused = true;
        }
    }

    public void ToMainMenu()
    {
        pause = false;
        GameControl.instance.isPaused = false;
        SceneManager.LoadScene(0);
    }
}
