using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance; //A reference to our game control script so we can access it statically.
    public Text scoreText;                        //A reference to the UI text component that displays the player's score.
    public GameObject gameOvertext;                //A reference to the object that displays the text which appears when the player dies.
    public int score = 0;                        //The player's score.
    public bool gameOver = false;                //Is the game over?
    public float scrollSpeed = -0.5f;
    public Text livesText;
    public int lives = 3;
    private AudioSource pop;
    private int highscore;
    public bool isPaused;

    private void Start()
    {
        pop = GetComponent<AudioSource>();
    }

    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (PlayerPrefs.HasKey("highscore1"))
            {
                highscore = PlayerPrefs.GetInt("highscore1");
            }
            else
            {
                highscore = 0;
                PlayerPrefs.SetInt("highscore1", highscore);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (PlayerPrefs.HasKey("highscore2"))
            {
                highscore = PlayerPrefs.GetInt("highscore2");
            }
            else
            {
                highscore = 0;
                PlayerPrefs.SetInt("highscore2", highscore);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (PlayerPrefs.HasKey("highscore3"))
            {
                highscore = PlayerPrefs.GetInt("highscore3");
            }
            else
            {
                highscore = 0;
                PlayerPrefs.SetInt("highscore3", highscore);
            }
        }

        if (instance == null)

            instance = this;

        else if(instance != this)

            Destroy (gameObject);

    }
   
    void Update()
    {
        if (this.lives == 0)
        {
            gameOvertext.SetActive(true);
            gameOver = true;
        }

        if (gameOver && Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
 
    public void BubbleScore()
    {
        if (gameOver)    
            return;
        score++;

        this.UpdateHighScore();

        scoreText.text = "Score: " + score.ToString();
        pop.Play();
    }

    public void ShowLives()
    {
        if (gameOver)
            return;

        livesText.text = lives.ToString();
    }

    public void UpdateHighScore()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highscore1", highscore);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highscore2", highscore);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highscore3", highscore);
            }
        }
    }

}
