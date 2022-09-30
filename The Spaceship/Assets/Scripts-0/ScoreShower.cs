using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreShower : MonoBehaviour
{

    public TMP_Text scoretext;
    public TMP_Text highscoretext;

    private void Start()
    {
        show();
    }

    private void show()
    {
        scoretext.text = PlayerPrefs.GetInt("Score").ToString();
        highscoretext.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

}
