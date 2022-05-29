using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour 
{
    public static AdsManager instance;
    private string gameId= "4081097";
    private string InterAd = "video";
    private string RewardAd = "rewardedVideo";


    public bool TestMode;
    static int loadCount = 1;

    private void Awake()
    {
        if (instance != null)
        { Destroy(gameObject); return; }
        instance = this;
    }
    void Start()
    {
        //Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, TestMode);
    }

    public void showAd()
    {
        if (loadCount % 3 == 0)
        {
            ShowInterstitialAd();
        }
        loadCount++;
    }

    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady(InterAd))
        {
            Advertisement.Show(InterAd);
        }
        else
        {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
    }
    public void Rewarded_ADs()
    {
        if (Advertisement.IsReady(RewardAd))
        {
            Advertisement.Show(RewardAd);
            //msg 
            //debug.text = "Rewarded ADs are successfully shown";
            Debug.Log("ads show succes");
        }
        else
        {
            Debug.Log("Rewarded ads are not available");
        }
    }

    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
            AddCoinsRewardDailyReward();
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
            Debug.Log("skip");
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
    void AddCoinsRewardDailyReward()
    {
        GameDataManager.AddCoin(DailyRewards.amountScoreDaily);
        Debug.Log("Daily : " + DailyRewards.amountScoreDaily);
    }
    public void OnUnityAdsReady(string surfacingId)
    {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == RewardAd)
        {
            // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
        }
    }
    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string surfacingId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
    public void OnDestroy()
    {
        //Advertisement.RemoveListener(this);
    }
}
