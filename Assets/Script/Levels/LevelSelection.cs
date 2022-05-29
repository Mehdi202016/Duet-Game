using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelection : MonoBehaviour
{
    [SerializeField] Button[] lvlButtons;

    void Start()
    {
        Time.timeScale = 1;
        int levelAt = PlayerPrefs.GetInt("levels", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelAt)
                lvlButtons[i].interactable = false;
        }
        MangerCoins.intance.updateCoinUIText();
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void EndlessGame()
    {
        SceneManager.LoadScene("BonusLevel");
    }
}
