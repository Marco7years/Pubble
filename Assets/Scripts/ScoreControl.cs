using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public TextMeshProUGUI highscore1text;
    public TextMeshProUGUI highscore2text;
    public TextMeshProUGUI highscore3text;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("highscore1"))
        {
            highscore1text.text = PlayerPrefs.GetInt("highscore1").ToString();
        }

        if (PlayerPrefs.HasKey("highscore2"))
        {
            highscore2text.text = PlayerPrefs.GetInt("highscore2").ToString();
        }

        if (PlayerPrefs.HasKey("highscore3"))
        {
            highscore3text.text = PlayerPrefs.GetInt("highscore3").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
