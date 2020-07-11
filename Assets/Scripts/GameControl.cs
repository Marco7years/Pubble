using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;            //A reference to our game control script so we can access it statically.
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
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetInt("highscore");
        }
        else
        {
            highscore = 0;
            PlayerPrefs.SetInt("highscore", highscore);
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
            SceneManager.LoadScene(0);
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
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
            //PlayerPrefs.Save();
        }
        Debug.Log(PlayerPrefs.GetInt("highscore").ToString());
    }

}
