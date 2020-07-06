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

    void Awake()
    {
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

        scoreText.text = "Score: " + score.ToString();
    }

    public void ShowLives()
    {
        if (gameOver)
            return;

        livesText.text = lives.ToString();
    }

}
