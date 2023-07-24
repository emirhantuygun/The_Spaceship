using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdManagerInter : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    string _adUnitId = "ca-app-pub-4325592066865117/3470322558";
    bool showed;
    public Button playbutton;

    public void Start()
    {
        if (PlayerPrefs.GetInt("adcounter", 0) >= 4)
        {
            LoadInterstitialAd();
            MobileAds.Initialize((InitializationStatus initStatus) =>{});
            showed = false;
            playbutton.interactable = false;
            StartCoroutine(Timer());
        }
    }

    public void Update()
    {
        if(interstitialAd != null && interstitialAd.CanShowAd())
        {
            if(showed == false)
            {
                ShowAd();
                PlayerPrefs.SetInt("adcounter", 0);
                showed = true;
            }
        }
    }

    void LoadInterstitialAd()
    {      
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        Debug.Log("Loading the interstitial ad.");

        var adRequest = new AdRequest.Builder()
                .AddKeyword("unity-admob-sample")
                .Build();

        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {
                    Debug.LogError("interstitial ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Interstitial ad loaded with response : "
                          + ad.GetResponseInfo());

                interstitialAd = ad;
            });
    }
    public void ShowAd()
    {
        if (interstitialAd != null && interstitialAd.CanShowAd())
        {
            Debug.Log("Showing interstitial ad.");
            interstitialAd.Show();
        }
        else
        {
            Debug.LogError("Interstitial ad is not ready yet.");
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(8f);
        {
            playbutton.interactable = true;
        }
    }
}