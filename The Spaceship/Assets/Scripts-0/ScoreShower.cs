using UnityEngine;
using TMPro;

public class ScoreShower : MonoBehaviour
{

    public TMP_Text scoretext;
    public TMP_Text highscoretext;
    public TMP_Text cashtext;
    public TMP_Text cashtext2;

    public TMP_Text scoreformoney;
    public TMP_Text fuelcosttext;
    public TMP_Text moneytext;

    private void Start()
    {        
        scoretext.text = PlayerPrefs.GetInt("Score", 0).ToString();
        highscoretext.text = "best:   " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        cashtext.text = PlayerPrefs.GetInt("cash", 0).ToString();
        cashtext2.text = PlayerPrefs.GetInt("cash", 0).ToString();

        scoreformoney.text = "$" + PlayerPrefs.GetInt("Score", 0);
        fuelcosttext.text = "$" + PlayerPrefs.GetInt("fuelcost",0);
        moneytext.text = "$" + PlayerPrefs.GetInt("newcash", 0);
    }

    private void Update()
    {
        if (ShopManager.changes == true)
        {
            cashtext.text = PlayerPrefs.GetInt("cash", 0).ToString();
            cashtext2.text = PlayerPrefs.GetInt("cash", 0).ToString();
            ShopManager.changes = false;
        }
        
        if (IAPManager.purchased == true)
        {
            cashtext.text = PlayerPrefs.GetInt("cash", 0).ToString();
            cashtext2.text = PlayerPrefs.GetInt("cash", 0).ToString();
            IAPManager.purchased = false;        
        }
    }
}
