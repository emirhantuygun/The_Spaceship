using System.Collections;
using UnityEngine;

public class TimeSlowing : MonoBehaviour
{
    float doubleTapTime = 0.2f;
    private int tapCount = 0;
    private float lastTapTime;

    private AudioSource audioSource;
    public static bool slowed = false;
    int counter;
    int score;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        counter = 0;
        PlayerPrefs.SetInt("used", 0);
    }

    void Update()
    {
        score = PlayerPrefs.GetInt("Score");

        if (slowed == false && score != 0 && score != 50 && score != 100 && counter < PlayerPrefs.GetInt("counter"))
        {
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    tapCount++;

                    if (tapCount == 1)
                    {
                        lastTapTime = Time.time;
                    }
                    else if (tapCount == 2 && Time.time - lastTapTime < doubleTapTime)
                    {
                        tapCount = 0;
                        lastTapTime = 0;
                        OnDoubleTap();
                    }
                    else if (tapCount > 2 || Time.time - lastTapTime > doubleTapTime)
                    {
                        tapCount = 1;
                        lastTapTime = Time.time;
                    }
                }
            }
        }
    }

    public void OnDoubleTap()
    {
        if (Buttons.sound == true)
            audioSource.Play();

        slowed = true;
        counter++;
        PlayerPrefs.SetInt("used", counter);
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        {
            slowed = false;
        }
    }
}
