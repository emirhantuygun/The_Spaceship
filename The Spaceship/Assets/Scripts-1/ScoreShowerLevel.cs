using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreShowerLevel : MonoBehaviour
{

    int score;
    int highscore;
    
    bool blue;
    bool green;
    bool magenta;
    bool orange;
    bool purple;
    bool yellow;
    bool turquoise;

    public TMP_Text scoretext;
    public Material skyboxblue;
    public Material skyboxgreen;
    public Material skyboxmagenta;
    public Material skyboxorange;
    public Material skyboxpurple;
    public Material skyboxyellow;
    public Material skyboxturquoise;

    private void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", 0);       
        scoretext.text = "0";
        highscore = PlayerPrefs.GetInt("Highscore");
    }
    
    void OnTriggerEnter(Collider planet)
    {
        if (planet.tag == "Planets" && Failing.isDead == false)
        {
            scorecounter();
            Destroy(planet.gameObject, 3f);
        }
    }

    private void Update()
    {
        if(Shockwave.shockscore == true)
        {
            Shockwave.shockscore = false;
            scorecounter();
            scorecounter();
            scorecounter();
            scorecounter();
        }
        
        if(Bullet.weaponscore == true)
        {
            Bullet.weaponscore = false;
            scorecounter();
        }
       
        if (Failing.isDead == true)
            StartCoroutine(Timer());


        if(score >= 25 && score < 50)
        {
            if (blue == false)
            {
                blue = true;
                RenderSettings.skybox = skyboxblue;
            }
        }
        
        if(score >= 50 && score < 100)
        {
            if (green == false)
            {
                green = true;
                RenderSettings.skybox = skyboxgreen;
            }
        }
        
        if(score >= 100 && score < 150)
        {
            if (magenta == false)
            {
                magenta = true;
                RenderSettings.skybox = skyboxmagenta;
            }
        }

        if(score >= 150 && score < 200)
        {
            if (orange == false)
            {
                orange = true;
                RenderSettings.skybox = skyboxorange;
            }
        }
        
        if(score >= 200 && score < 250)
        {
            if (purple == false)
            {
                purple = true;
                RenderSettings.skybox = skyboxpurple;
            }
        }
        
        if(score >= 250 && score < 300)
        {
            if (yellow == false)
            {
                yellow = true;
                RenderSettings.skybox = skyboxyellow;
            }
        }
        
        if(score >= 300)
        {
            if (turquoise == false)
            {
                turquoise = true;
                RenderSettings.skybox = skyboxturquoise;
            }
        }
    }

    void scorecounter()
    {
        score++;
        PlayerPrefs.SetInt("Score", score);
        scoretext.text = score + "";

        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.5f);
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
