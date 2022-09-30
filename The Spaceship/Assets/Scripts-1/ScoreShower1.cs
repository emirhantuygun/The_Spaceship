using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreShower1 : MonoBehaviour
{
    public TMP_Text scoretext;
    public SMovement a;
    public GameObject ss;
    int score = 0;
    int highscore;
 

    private void Start()
    {
        InvokeRepeating("scorecounter", 1.75f, 1);
        PlayerPrefs.SetInt("Score", 0);

        highscore = PlayerPrefs.GetInt("Highscore");
    }

    private void Update()
    {
        if (a.isDead == true)
            CancelInvoke("scorecounter");
    }

    void scorecounter()
    {
        score += 4;
        PlayerPrefs.SetInt("Score", score);
        scoretext.text = score + "";


        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
       
        
        if(score==100)
            SceneManager.LoadScene("Scene2");
    }







}
