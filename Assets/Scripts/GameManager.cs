using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject AdManager;

    // Update is called once per frame
    void Update()
    {
        while (true)
        {
            KeepShowingAds();
        }
    }

    //keep showing ads
    public void KeepShowingAds()
    {
        AdManager.GetComponent<RewardedAd>().ShowAd();
    }

    //show banner ad
    public void ShowBannerAd()
    {
        AdManager.GetComponent<BannerAd>().ShowAd();
    }

    //show interstitial ad
    public void ShowInterstitialAd()
    {
        AdManager.GetComponent<InterstitialAd>().ShowAd();
    }

    //show rewarded ad
    public void ShowRewardedAd()
    {
        AdManager.GetComponent<RewardedAd>().ShowAd();
    }
}
