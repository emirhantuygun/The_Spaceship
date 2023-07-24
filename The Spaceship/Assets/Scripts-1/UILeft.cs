using UnityEngine;
using TMPro;

public class UILeft : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shockwave;
    public GameObject timeslowing;
    public GameObject leftobject;
    
    public TMP_Text lefttext;
    public TextMeshProUGUI font;

    int car, left;
    
    void Start()
    {
        car = PlayerPrefs.GetInt("SelectedCar", 0);

        if (car == 2 || car == 4 || car == 10 || car == 13 || car == 14 || car == 16 || car == 18 || car == 20)
        {
            bullet.SetActive(true);
            leftobject.SetActive(true);
        }

        if (car == 3 || car == 5 || car == 7 || car == 8 || car == 11 || car == 12 || car == 19)
        {
            shockwave.SetActive(true);
            leftobject.SetActive(true);
        }

        if (car == 1 || car == 6 || car == 9 || car == 15 || car == 17)
        {
            timeslowing.SetActive(true);
            leftobject.SetActive(true);
        }

        if (car == 20)
        {
            font.fontSize = 45;
            lefttext.text = "∞";
        }
    }

    void Update()
    {
        if(Failing.isDead == true)
        {
            font.fontSize = 32;

            bullet.SetActive(false);
            shockwave.SetActive(false);
            timeslowing.SetActive(false);
            leftobject.SetActive(false);          
        }

        if (car != 0 && car != 20)
        {
            left = PlayerPrefs.GetInt("counter") - PlayerPrefs.GetInt("used",0);
            lefttext.text = left + "";
        }
    }
}
