using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseObject;

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
