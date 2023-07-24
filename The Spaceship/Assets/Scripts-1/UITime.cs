using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITime : MonoBehaviour
{
    public Image timer;
    public TMP_Text timertext;
    public GameObject timerobj;
    public GameObject textobj;

    float currenttime;
    bool works;

    void Start()
    {
        works = false;
    }

    void Update()
    {
        if (Failing.isDead == true)
        {
            timerobj.SetActive(false);
            textobj.SetActive(false);
        }

        if (TimeSlowing.slowed == true)
        {
            if (works == false)
            {
                works = true;
                currenttime = 10f;
                
                timerobj.SetActive(true);
                textobj.SetActive(true);
                
                StartCoroutine(Timer());
            }
        }
    }

    IEnumerator Timer()
    {
        while (currenttime > 0f)
        {
            currenttime -= Time.deltaTime;
            timer.fillAmount = Mathf.Lerp(0f, 1f, currenttime / 10);
            timertext.text = Mathf.Round(currenttime).ToString();

            yield return null;
        }

        timertext.text = "0";

        timerobj.SetActive(false);
        textobj.SetActive(false);
        works = false;
    }
}
