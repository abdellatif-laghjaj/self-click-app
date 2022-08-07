using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject AdManager;

    private void Start() {
        ShowInterstitialAd();
        //show rewarded ad every 30 seconds
        InvokeRepeating("ShowRewardedAd", 0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        ShowRewardedAd();
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
