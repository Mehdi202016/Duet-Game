using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ShopManager : MonoBehaviour
{
    public GameObject Shop;

    [Header("Shop")]
    int current_player=0;
    public GameObject[] select_player;
    public int[] cost_player;
    string[] value_player = new string[5];
    int coins;
    public int[] buy_player;
    [SerializeField] Text MessageError;
    private void Start()
    {
        coins = GameDataManager.getCoins();
        for (int i = 0; i < select_player.Length; i++)
        {
            value_player[i] = "" + i;
            select_player[i].SetActive(false);
            buy_player[i] = PlayerPrefs.GetInt(value_player[i]);
        }
    }
    private void Update()
    {
        for (int i = 0; i < select_player.Length; i++)
        {
            buy_player[i] = PlayerPrefs.GetInt(value_player[i]);
            if (i == buy_player[i])
            {
                select_player[i].SetActive(true);
            }
        }
    }
    public void ButtonOpenShops()
    {
        Shop.SetActive(true);
    }

    public void ButtonCloseShops()
    {
        Shop.SetActive(false);
    }

    public void BuyCharacter(int io)
    {
        if (cost_player[io] <= coins)
        {
            GameDataManager.AddCoin(-cost_player[io]);
            PlayerPrefs.SetInt(value_player[io],io);
            //Admobe.instance.ShowInterstilialAd();
            AdsManager.instance.ShowInterstitialAd();
        }
        else
        {
            AnimatNoMoreCoinsText();
        }
    }
    void AnimatNoMoreCoinsText()
    {
        MessageError.transform.DOComplete();
        MessageError.DOComplete();
        MessageError.transform.DOShakePosition(3f, new Vector3(5f, 0f, 0f), 10, 0);
        MessageError.DOFade(1f, 3f).From(0f).OnComplete(() =>
        {
            MessageError.DOFade(0f, 1f);
        });

    }
    public void SelectCharacter(int io)
    {
           PlayerPrefs.SetInt("current_player", io);
    }
}
