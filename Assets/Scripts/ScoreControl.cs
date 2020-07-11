using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public TextMeshProUGUI highscore1text;
    public Text highscore2text;
    public Text highscore3text;
    public int ye = 21;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore1text.text = PlayerPrefs.GetInt("highscore").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
