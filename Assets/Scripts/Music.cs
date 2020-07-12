using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    private AudioSource music;
    private bool isPlaying;
    private bool musicInGame;

    // Start is called before the first frame update
    void Awake()
    {
        if(!PlayerPrefs.HasKey("isMuted"))
        {
            PlayerPrefs.SetInt("isMuted", 0);
        }
        music = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("isMuted") == 0)
        {
            music.Play();
            isPlaying = true;
        }
        if (PlayerPrefs.GetInt("isMuted") == 1)
        {
            music.Pause();
            isPlaying = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
    }

    public void PauseResume()
    {
        if (isPlaying == true)
        {
            PlayerPrefs.SetInt("isMuted", 1);
            music.Pause();
            isPlaying = false;
        }
        else 
        {
            PlayerPrefs.SetInt("isMuted", 0);
            music.Play();
            isPlaying = true;
        }

    }

    public void PauseResumeInGame()
    {
        if (isPlaying == true)
        {
            PlayerPrefs.SetInt("isMuted", 1);
            music.Pause();
            isPlaying = false;
            musicInGame = true;
        }

        else if (musicInGame == true)
        {
            PlayerPrefs.SetInt("isMuted", 0);
            music.Play();
            isPlaying = true;
        }
    }

}