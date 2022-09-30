using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShower2 : MonoBehaviour
{

    public TMP_Text scoretext;
    public SMovement a;
    int score = 100;
    int highscore;

    private void Start()
    {
        InvokeRepeating("scorecounter2", 1.75f, 1);
        PlayerPrefs.SetInt("Score", 0);

        highscore = PlayerPrefs.GetInt("Highscore");
    }

    private void Update()
    {
        if (a.isDead == true)
        {
            CancelInvoke("scorecounter2");
            Debug.Log("it is working");
        }
    }

    void scorecounter2()
    {
        score += 4;
        PlayerPrefs.SetInt("Score", score);
        scoretext.text = score + "";


        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
    }


}