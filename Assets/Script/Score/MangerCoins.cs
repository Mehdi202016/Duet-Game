using UnityEngine;
using UnityEngine.UI;

public class MangerCoins : MonoBehaviour
{

    [SerializeField] Text CoinsText;

    #region sengleton
    public static MangerCoins intance;
    private void Awake()
    {
        if (intance == null)
        {
            intance = this;
        }
    }
    #endregion

    //1000 coins === 1K coins affichage
    int coinsValue = 0;
    public void updateCoinUIText()
    {
    setCoinsText(CoinsText, GameDataManager.getCoins());
    }
    void setCoinsText(Text txt, int value)
    {
        if (value >= 1000)
            txt.text = string.Format("{0}k.{1}", (value / 1000), getFirstDegeltalForNumber(value % 1000));
        else
            txt.text = value.ToString();
        coinsValue = value;
    }
    int getFirstDegeltalForNumber(int num)
    {
        return int.Parse(num.ToString()[0].ToString());
    }
}
