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
}
