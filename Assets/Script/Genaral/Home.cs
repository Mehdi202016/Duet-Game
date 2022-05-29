using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public GameObject PanelQuit;
    public GameObject Gdpr;
    string key;
    int check;
    

    private void Start()
    {
        Invoke("onClick", 2);
    }
    public void MenuLevel()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    private void Update()
    {
        MangerCoins.intance.updateCoinUIText();
        check = PlayerPrefs.GetInt(key);
        if (check == 1)
        {
            Gdpr.SetActive(false);
        }
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
    public void ButtonAffichePanel()
    {
        PanelQuit.SetActive(true);
    }
    public void ButtonhidePanel()
    {
        PanelQuit.SetActive(false);
    }
    public void onClick()
    {
        PlayerPrefs.SetInt(key, 1);
    }

    public void PrivacyPolicy()
    {
        Application.OpenURL("https://policies.google.com/privacy");
    }
    
}
