using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class AdManagerBanner : MonoBehaviour
{
    BannerView _bannerView;
    string _adUnitId = "ca-app-pub-4325592066865117/2868433159";

    public void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>{});
        LoadAd();
    }

    public void LoadAd()
    {
        if (_bannerView == null)
        {
            CreateBannerView();
        }

        var adRequest = new AdRequest.Builder()
            .AddKeyword("unity-admob-sample")
            .Build();

        _bannerView.LoadAd(adRequest);
    }

    public void CreateBannerView()
    {
        if (_bannerView != null)
        {
            DestroyAd();
        }

        _bannerView = new BannerView(_adUnitId, AdSize.Banner, AdPosition.Bottom);
    }


    public void DestroyAd()
    {
        if (_bannerView != null)
        {
            _bannerView.Destroy();
            _bannerView = null;
        }
    }
}