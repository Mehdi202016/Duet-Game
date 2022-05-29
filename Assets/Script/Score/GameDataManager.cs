using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static int coin=0;
    public static int getCoins()
    {
        return PlayerPrefs.GetInt("score");
    }

    public static void AddCoin(int amount)
    {
        coin = (amount+getCoins());
        Debug.Log("coins : " + coin);
            PlayerPrefs.SetInt("score", coin);
    }
}
