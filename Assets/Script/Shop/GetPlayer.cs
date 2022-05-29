using UnityEngine;
using UnityEngine.UI;

public class GetPlayer : MonoBehaviour
{
    int current_player;
    public GameObject[] Players;

    void showPlayer()
    {
        current_player = PlayerPrefs.GetInt("current_player", current_player);
        //Debug.Log(current_player);
        for (int i = 0; i < Players.Length; i++)
        {
            if (current_player == i)
            {
                Players[i].SetActive(true);
            }
        }
    }
    void Update()
    {
        showPlayer();
        if (current_player==0)
        {
            //Player 1 show
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
        }
        else if (current_player == 1)
        {
            //Player 2 show
            Players[0].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
        }
        else if (current_player == 2)
        {
            //Player 3 show
            Players[1].SetActive(false);
            Players[0].SetActive(false);
            Players[3].SetActive(false);
        }
        else if (current_player == 3)
        {
            //Player 4 show
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[0].SetActive(false);
        }
    }
}
